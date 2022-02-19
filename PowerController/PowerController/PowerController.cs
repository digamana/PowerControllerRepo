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
namespace PowerController
{
    public partial class PowerController : Form
    {
        /*
        1.(O)開機後執行
        2.序列化記住選項
        3.右下角執行
        4.列出所有選項電源計畫
        5.UI倒數更新
        6.UI的下拉式選單內容，依據電腦中的電源計畫數量不同而不同

         
         */
        public PowerController()
        {
            InitializeComponent();
     
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
    }
}
