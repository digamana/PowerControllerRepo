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

        private readonly string ICON_FILE_PATH = $"{AppDomain.CurrentDomain.BaseDirectory}IMG\\ImgPower.ico";
        frmAppSetting frmAppSetting = new frmAppSetting(); 
        private int setIdleTime { get; set; } = 0;
        private PowerPlan powerPlan { get; set; }
        private bool bTriggerMIn { get; set; } = false;
        private bool IsMoving { get; set; } = false;
        private readonly string[] AryCurrentPowerPlan = new PowerPlan().getCurrentPowerPlan();
        bool bSoftwareActive { get; set; } = false;
        FormClosingEventArgs formClosingEventArgs { get; set; }
        ColorState CurrentColorState { get; set; }
        public PowerController()
        {
          
            InitializeComponent();
             
            setProcessBar(1);
            powerPlan = new PowerPlan();
            lblCurrentPowerPlan.Text = powerPlan.getCurrentPowerPlan()[0];
            notifyIcon1.Text = this.Text;
            foreach (var item in powerPlan.dictPowerPlanInfo)
            {
                cmbActive.Items.Add(item.Key);
                cmbIdle.Items.Add(item.Key);
                cmbExe.Items.Add(item.Key);
                //cmbCurrentPowerPlan.Items.Add(item.Key);
            }
            var aa=powerPlan.getCurrentPowerPlan();

         
            //Process.Start("powercfg"," /setactive 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c");
            DeserializeFormSettings();
        }
 
        /// <summary>
        /// 變更當前電源設定（需指定電源名稱的唯一碼）
        /// </summary>
        /// <param name="PowerGuid"></param>
        private void ChangePower(string PowerGuid)
        {
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
            e.Cancel = true;
            formClosingEventArgs = e;
            formClosingEventArgs.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            //Assigning the current selected index of combobox to serialize class.
            SaveParameter SP = new SaveParameter();
            SP.cmbActive_selectIndex = this.cmbActive.SelectedIndex;
            SP.cmbIdle_selectIndex = this.cmbIdle.SelectedIndex;
            SP.cmbExecute_selectIndex = this.cmbExe.SelectedIndex;
            SP.cmbCountDown_selectIndex = this.cmbSetIdleTime.SelectedIndex;
            SP.isStop = this.chkStop.Checked == false ? 0 : 1;
            SP.ActiveComputerStart = this.cmbTurnOn.Checked == false ? 0 : 1;
            SP.CloseHide = this.chkCloseHide.Checked == false ? 0 : 1;
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

        /// <summary>
        /// 反序列化，解析並設定上次關閉軟體前的設定
        /// </summary>
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
                    this.chkStop.Checked = f1.isStop == 0 ? false : true;
                    this.cmbTurnOn.Checked = f1.ActiveComputerStart == 0 ? false : true;
                    this.chkCloseHide.Checked = f1.CloseHide == 0 ? false : true;
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
        /// <summary>
        /// 設定倒數計時的碼表
        /// </summary>
        /// <param name="pBarmax"></param>
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
            if (proBarIdleCountDown.Value == 0 && timer1.Enabled == true)
            {
                Console.WriteLine("執行設定作業");
                ChangePower(powerPlan.dictPowerPlanInfo[cmbIdle.SelectedItem.ToString()]);
                //lblExecuting.BackColor = Color.Transparent;
                //lblIdle.BackColor = Color.FromArgb(128, 255, 128);
                //lblActive.BackColor = Color.Transparent;
                chnageColorState(ColorState.Idle);
                lblCurrentPowerPlan.Text = new PowerPlan().getCurrentPowerPlan()[0];
            }
            else
            {
                chnageColorState(ColorState.Active);
                lblCurrentPowerPlan.Text = new PowerPlan().getCurrentPowerPlan()[0];

            }
            if (proBarIdleCountDown.Value == 0)timer1.Enabled=false;
        }

        private void cmbSetIdleTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] strArr = cmbSetIdleTime.Text.Split(':');
            setIdleTime = int.Parse(strArr[0]) * 3600 + int.Parse(strArr[1]) * 60 + int.Parse(strArr[2]);
            setProcessBar(setIdleTime);
        }

        private void cmbTurnOn_CheckedChanged(object sender, EventArgs e)
        {
            addToRegForRun reg = new addToRegForRun();
            string key = "PowerController";
            string value = System.Environment.CommandLine.Replace("\"", "");  //會取得程式的位址加雙引號，所以要移掉
            if (cmbTurnOn.Checked)
            {
                reg.add(key, value);
                reg.chk(key);
            }
            else
                reg.remove(key);
 
        }
        /// <summary>
        /// 開啟控制台的電源計畫
        /// </summary>
        private void OpenPowerPlan()
        {
            var cplPath = System.IO.Path.Combine(Environment.SystemDirectory, "control.exe");
            System.Diagnostics.Process.Start(cplPath, "/name Microsoft.PowerOptions");
        }
        private void btnOpenPowerPlan_Click(object sender, EventArgs e)
        {
            OpenPowerPlan();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {

            lblIdleCountDwon.Text = String.Format($"{proBarIdleCountDown.Value}ｓ");
            
            bSoftwareActive = frmAppSetting.ScanColumns(frmAppSetting._dgpProcess);
           // lblCurrentPowerPlan.Text = powerPlan.getCurrentPowerPlan()[0];
            if (chkStop.Checked) return;
            //如果有列表中的軟體在執行中
            if (bSoftwareActive)
            {
                CurrentColorState = ColorState.Exception;
                chnageColorState(ColorState.Exception);
                cmbActive.Enabled = false;
                cmbIdle.Enabled = false;
                //且當前電腦的電源設定跟UI中的 軟體執行時的電源設定不符合，則執行電源設定變更
                //雙重if是為了避免一直執行設定電源的cmd指令
                if (powerPlan.getCurrentPowerPlan()[0] != cmbExe.Text)
                {
                    ChangePower(powerPlan.dictPowerPlanInfo[cmbExe.SelectedItem.ToString()]);
                } 
            }
            else if (GetLastUserInput.GetIdleTickCount() < 50)
            {

                chnageColorState(ColorState.Active);
                cmbActive.Enabled = true;
                cmbIdle.Enabled = true;
                ChangePower(powerPlan.dictPowerPlanInfo[cmbActive.SelectedItem.ToString()]);
                setProcessBar(setIdleTime);
                timer1.Enabled = true;
            }
 

        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            frmAppSetting.ShowDialog(this);
            var aa = frmAppSetting._dgpProcess.Rows;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.ShowInTaskbar == false)
                notifyIcon1.Visible = true;

            this.ShowInTaskbar = true;
            this.Show();
            this.Activate();
            this.WindowState = FormWindowState.Normal;

        }

        private void chkStop_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStop.Checked) timer1.Enabled = false;
            else timer1.Enabled = true;
        }

        private void ToolStripMenu_EventClick(object sender, EventArgs e)
        {
            ToolStripMenuItem tsm = (ToolStripMenuItem)sender;
            switch (tsm.Name)
            {
                case "stopToolStripMenuItem":
                    tsm.Checked= !tsm.Checked;

                    if(tsm.Checked==true) tsm.CheckState = CheckState.Checked;
                    else tsm.CheckState = CheckState.Unchecked;

                    break;
                case "powerPlanToolStripMenuItem":
                    OpenPowerPlan();
                    break;
                case "hideToolStripMenuItem":
 
                    this.WindowState = FormWindowState.Minimized;
                    this.ShowInTaskbar = false;
                    break;
                case "showToolStripMenuItem":
                    WindowState = FormWindowState.Normal;
                    break;
                case "exitToolStripMenuItem":
                    this.Dispose();
                    this.Close();
                    break;
            }
        }

        private void PowerController_Resize(object sender, EventArgs e)
        {
            //不使用這個事件的話，會發生多個應用程式ico同時存在右下角的現象
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Icon = Icon.ExtractAssociatedIcon(ICON_FILE_PATH);
                notifyIcon1.Visible = true;
            }
            else
            {
                // kill the icon
                notifyIcon1.Icon = null;
            }
            if (this.chkCloseHide.Checked == false && formClosingEventArgs != null)
            {
                formClosingEventArgs.Cancel = false;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            { 
            }

        }

        private void PowerController_Move(object sender, EventArgs e)
        {
             
        }
        private enum ColorState 
        {
            /// <summary>
            /// 活動中
            /// </summary>
            Active,
            /// <summary>
            /// 閒置中
            /// </summary>
            Idle,
            /// <summary>
            /// 中清單的軟體，使用中的時候
            /// </summary>
            Exception,
        }
        /// <summary>
        /// 根據狀態改變Lable顏色
        /// </summary>
        /// <param name="_ColorState"></param>
        private void chnageColorState(ColorState _ColorState)
        {
            CurrentColorState = _ColorState;
            switch (_ColorState)
            { 
            case ColorState.Active:
                    lblActive.BackColor = Color.FromArgb(128, 255, 128);
                    lblIdle.BackColor = Color.Transparent;
                    lblExecuting.BackColor = Color.Transparent;
                   
                    break;
            case ColorState.Idle:
                    lblActive.BackColor = Color.Transparent;
                    lblIdle.BackColor = Color.FromArgb(128, 255, 128);
                    lblExecuting.BackColor = Color.Transparent;
                    break;
                case ColorState.Exception:
                    lblActive.BackColor = Color.Transparent;
                    lblIdle.BackColor = Color.Transparent;
                    lblExecuting.BackColor = Color.FromArgb(128, 255, 128);
                    break;
            }
            
         

        }
    }
}
