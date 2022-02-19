﻿using System;
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
        private PowerPlan powerPlan { get; set; }
        public PowerController()
        {
           
            InitializeComponent();
            powerPlan = new PowerPlan();
            foreach (var item in powerPlan.dictPowerPlanInfo)
            {
                chkActive.Items.Add(item.Key);
            }
            
            //Process.Start("powercfg"," /setactive 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c");

        }

        private void chkAutoOpen_CheckedChanged(object sender, EventArgs e)
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
            MessageBox.Show("end");
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
    }
}
