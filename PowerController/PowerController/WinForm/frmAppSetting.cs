using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace PowerController.WinForm
{
    public partial class frmAppSetting : Form
    {
        public frmAppSetting()
        {
            InitializeComponent();

            AddItem("SnippingTool");
            var aa=System.Diagnostics.Process.GetProcesses();
            if (System.Diagnostics.Process.GetProcessesByName("Notepad++").Length > 0)
            {
                Console.WriteLine("SSS");
                // Is running
            }
        }
        private void AddItem(object SoftwareName)
        {
            DataGridViewRow row = (DataGridViewRow)dgvProcess.Rows[0].Clone();
            row.Cells[0].Value = SoftwareName;
            row.Cells[1].Value = "NotThing";
            dgvProcess.Rows.Add(row);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItem("SnippingTool");

            //if (checkColumnNotSameItem("SnippingTool") == false)
            //{
            //    AddItem("SnippingTool");
            //}
            //else
            //{
            //    MessageBox.Show("", "已存在");

            //}

            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.ShowDialog();
            //string strFileName=System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName);


            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
            //openFileDialog1.FilterIndex = 1;
            //openFileDialog1.FileName = "";
            //DialogResult dialogResult1 = openFileDialog1.ShowDialog();
            //string strFileName = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);


            // Get the file version for the notepad.
            //FileVersionInfo myFileVersionInfo =
            //    FileVersionInfo.GetVersionInfo("E:\\Setup\\DiscordSetup.exe");
            //IsProcessOpen("F-Secure Consumer Main UI ");

            //var aa = Process.GetProcesses();
            //foreach (Process p in Process.GetProcesses())
            //{

            //    if (p.MainWindowTitle != "")
            //    {
            //        MessageBox.Show(p.MainWindowTitle);
            //    }
            //}
        }
        /// <summary>
        /// 確認新加入的Item 名稱是否已存在，基本上要回false才能允許加入新Item
        /// </summary>
        /// <param name="strText"></param>
        /// <returns></returns>
        private bool checkColumnNotSameItem(string strText)
        {
            foreach (DataGridViewRow item in dgvProcess.Rows)
            {
                if (item.Cells["State"].Value != null)
                {
                    if (item.Cells["ProcessName"].Value.ToString() == strText) return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 以Process名稱確認程式是否執行
        /// </summary>
        /// <param name="process_name"></param>
        /// <returns></returns>
        public bool IsProcessOpen(string process_name)
        {
            int iLen = System.Diagnostics.Process.GetProcessesByName(process_name).Length;
            return iLen > 0 ? true : false ;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var Cell = dgvProcess.Rows[0].Cells["ProcessName"].Value.ToString();
            bool bState = IsProcessOpen(Cell);

            if (bState == true)
            {

                changeItemTextAndColor(0, "Active", Color.Green);
            }

        }
        /// <summary>
        /// 變更Item的描述與背景顏色
        /// </summary>
        /// <param name="iSelectItem"></param>
        /// <param name="strText"></param>
        /// <param name="color"></param>
        public void changeItemTextAndColor(int iSelectItem,string strText, Color color)
        {
            dgvProcess.Rows[iSelectItem].Cells["State"].Value = strText;
            dgvProcess.Rows[iSelectItem].Cells["State"].Style.BackColor = color;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ScanColumns();
        }

        /// <summary>
        /// 掃描Columns中的所有ProcessName
        /// </summary>
        public  void ScanColumns()
        {
            foreach (DataGridViewRow item in dgvProcess.Rows)
            {
                if (item.Cells["State"].Value != null )  
                {
                    if (IsProcessOpen(item.Cells["ProcessName"].Value.ToString()))
                    {
                        item.Cells["State"].Value = "Active";
                        item.Cells["State"].Style.BackColor = Color.Green;
                    }
                    else
                    {
                        item.Cells["State"].Value = "Not Active";
                        item.Cells["State"].Style.BackColor = Color.Red;
                    }
                   
                }
                

            }
        }
    }
}
