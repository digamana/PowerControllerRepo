using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerController.Main;
using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ComponentFactory.Krypton.Toolkit;
using PowerController.WinForm;

namespace PowerController
{
    public partial class PowerController : Form
    {
        /*
        1.(O)開機後執行
        2.序列化記住選項
        3.右下角執行
        4.(O)列出所有選項電源計畫
        5.UI倒數更新
        6.(O)UI的下拉式選單內容，依據電腦中的電源計畫數量不同而不同

         
         */
        frmAppSetting frmAppSetting = new frmAppSetting(); 
        private int setIdleTime { get; set; } = 0;
        private PowerPlan powerPlan { get; set; }
        public PowerController()
        {
          
            InitializeComponent();
            setProcessBar(1);
            powerPlan = new PowerPlan();
            foreach (var item in powerPlan.dictPowerPlanInfo)
            {
                cmbActive.Items.Add(item.Key);
                cmbIdle.Items.Add(item.Key);
                cmbExe.Items.Add(item.Key);
            }

            //Process.Start("powercfg"," /setactive 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c");
            DeserializeFormSettings();
        }
        private void addPowerPlanInfoItem()
        {
            foreach (var item in powerPlan.dictPowerPlanInfo)
            {
                chkActive.Items.Add(item.Key);
            }
        }
         
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized;
                    this.Hide();
                }
                else if (this.WindowState == FormWindowState.Minimized)
                {
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                    this.Activate();
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                //if (MessageBox.Show("", "",MessageBoxButton.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                //{
                //    DialogResult = DialogResult.No;
                //    Dispose();
                //    Close();
                //}
            }
        }

        private void chkActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            var PowerGuid = powerPlan.dictPowerPlanInfo[chkActive.SelectedItem.ToString()];
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powercfg.exe",
                    Arguments = $"/setactive {PowerGuid}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            proc.Start();
        }

        private void PowerController_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Assigning the current selected index of combobox to serialize class.
            SaveParameter SP = new SaveParameter();
            SP.cmbActive_selectIndex = this.cmbActive.SelectedIndex;
            SP.cmbIdle_selectIndex = this.cmbIdle.SelectedIndex;
            SP.cmbExecute_selectIndex = this.cmbExe.SelectedIndex;
            SP.cmbCountDown_selectIndex = this.cmbSetIdleTime.SelectedIndex;
            SP.cmbWakeup_selectIndex = this.cmbWakeUp.SelectedIndex;
            //Serialize
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsout = new FileStream("ComboBoxSettings.binary", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (fsout)
                {
                    bf.Serialize(fsout, SP);
                }
            }
            catch (Exception Ex)
            {
                //Some Exception occured
            }
        }
        public void DeserializeFormSettings()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsin;

            if (File.Exists("ComboBoxSettings.binary"))
                fsin = new FileStream("ComboBoxSettings.binary", FileMode.Open, FileAccess.Read, FileShare.None);
            else
                return;
            try
            {
                using (fsin)
                {
                    SaveParameter f1 = (SaveParameter)bf.Deserialize(fsin);
                    this.cmbActive.SelectedIndex = f1.cmbActive_selectIndex;
                    this.cmbIdle.SelectedIndex = f1.cmbIdle_selectIndex;
                    this.cmbExe.SelectedIndex = f1.cmbExecute_selectIndex;
                    this.cmbSetIdleTime.SelectedIndex = f1.cmbCountDown_selectIndex;
                    this.cmbWakeUp.SelectedIndex = f1.cmbWakeup_selectIndex;
                }
            }
            catch (Exception Ex)
            {
                // "An error has occured";  
            }
        }
  

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void setProcessBar(int pBarmax)
        {
            proBarIdleCountDown.Visible = true;
            // 設定進度條最小值.
            proBarIdleCountDown.Minimum = 0;
            // 設定進度條最大值.
            proBarIdleCountDown.Maximum = pBarmax;
            // 設定進度條初始值
            proBarIdleCountDown.Value = pBarmax;
            // 設定每次增加的步長
            proBarIdleCountDown.Step = -1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            proBarIdleCountDown.PerformStep();
            label1.Text= GetLastUserInput.GetLastInputTime().ToString();
            if (proBarIdleCountDown.Value == 1) MessageBox.Show("","g");
        }

        private void cmbSetIdleTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            String setting = cmbSetIdleTime.Text;
            String[] strArr = cmbSetIdleTime.Text.Split(':');
            int setIdleTime = int.Parse(strArr[0]) * 3600 + int.Parse(strArr[1]) * 60 + int.Parse(strArr[2]);
            setProcessBar(setIdleTime);
        }

        private void cmbTurnOn_CheckedChanged(object sender, EventArgs e)
        {
            addToRegForRun reg = new addToRegForRun();
            string key = "PowerController";
            string value = System.Environment.CommandLine.Replace("\"", "");  //會取得程式的位址加雙引號，所以要移掉
            if (chkAutoOpen.Checked)
            {
                reg.add(key, value);
                reg.chk(key);
            }
            else
                reg.remove(key);
 
        }

        private void btnOpenPowerPlan_Click(object sender, EventArgs e)
        {
            GetLastUserInput.GetIdleTickCount();
            //var cplPath = System.IO.Path.Combine(Environment.SystemDirectory, "control.exe");
            //System.Diagnostics.Process.Start(cplPath, "/name Microsoft.PowerOptions");
        }
    }
}
