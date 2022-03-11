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
using ComponentFactory.Krypton.Toolkit;

namespace PowerController.WinForm
{
    public partial class frmAppSetting : Form
    {
        DataTable table;
        private const string COL1_PROCESSNAME = "ProcessName";
        private const string COL2_STATE = "State";
        private const string COL3_DESCRIBE = "Describe";
        private readonly string XML_SAVE_PATH = $@"{Directory.GetCurrentDirectory()}\PowerControl_Software_List.xml";
        public KryptonDataGridView _dgpProcess { get; }
        public frmAppSetting()
        {       
            InitializeComponent();
            _dgpProcess = this.dgvProcess;
            loadTable();
        }
        private void frmAppSetting_Load(object sender, EventArgs e)
        {
            loadTable();
        }
        private void btnEvent(object sender, EventArgs e)
        {
            KryptonButton btn = (KryptonButton)sender;
            switch (btn.Name)
            {
                case "btnAdd":
                    var Input = System.Diagnostics.Process.GetProcessesByName(txtbSoftwareName.Text);
                    if (Input.Length > 0) AddItem(txtbSoftwareName.Text, Input[0].MainWindowTitle);
                    else AddItem(txtbSoftwareName.Text, string.Empty);

                    txtbSoftwareName.Clear();
                    break;
                case "btnSave":
                    table.WriteXml(XML_SAVE_PATH);
                    MessageBox.Show("Save Sucess", "Message");
                    break;
                case "btnRemove":
                    if (table.Rows.Count != 0)
                    {
                        int iSelect = dgvProcess.CurrentCell.RowIndex;
                        table.Rows.RemoveAt(iSelect);
                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 載入先前儲存的XML軟體清單
        /// </summary>
        private void loadTable()
        {
            table = new DataTable("ListSoftware");
            table.Columns.Add(COL3_DESCRIBE, typeof(string));
            table.Columns.Add(COL1_PROCESSNAME, typeof(string));
            table.Columns.Add(COL2_STATE, typeof(string));
            if (File.Exists(XML_SAVE_PATH))  table.ReadXml(XML_SAVE_PATH);
            dgvProcess.DataSource = table;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strSoftwareName"></param>
        /// <param name="strDescribe"></param>
        private void AddItem(string strSoftwareName,string strDescribe)
        {
            if (IsProcessOpen(strSoftwareName)==false) MessageBox.Show($"ProcessNmae 「{strSoftwareName}」 Not Find", "Error");
            else if (checkColumnNotSameItem(strSoftwareName) == false) table.Rows.Add(strDescribe, strSoftwareName, "Nothing");
            else MessageBox.Show($"Software 「{strSoftwareName}」 already exists","Error");
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
                if (item.Cells[COL2_STATE].Value != null)
                {
                    if (item.Cells[COL1_PROCESSNAME].Value.ToString() == strText) return true;
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

        /// <summary>
        /// 變更Item的描述與背景顏色
        /// </summary>
        /// <param name="iSelectItem"></param>
        /// <param name="strText"></param>
        /// <param name="color"></param>
        public void changeItemTextAndColor(int iSelectItem,string strText, Color color)
        {
            dgvProcess.Rows[iSelectItem].Cells[COL2_STATE].Value = strText;
            dgvProcess.Rows[iSelectItem].Cells[COL2_STATE].Style.BackColor = color;
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
                {
                    var ProcessName = item.Cells[COL1_PROCESSNAME].Value.ToString();
                    if (IsProcessOpen(ProcessName))
                    {
                        item.Cells[COL2_STATE].Value = "Active";
                        item.Cells[COL2_STATE].Style.BackColor = Color.Green;

                        string strSoftwareTitle = System.Diagnostics.Process.GetProcessesByName(ProcessName)[0].MainWindowTitle;
                        if (strSoftwareTitle == string.Empty) item.Cells[COL3_DESCRIBE].Value = "Nothing";
                        else item.Cells[COL3_DESCRIBE].Value = strSoftwareTitle;
                    }
                    else
                    {
                        item.Cells[COL2_STATE].Value = "Not Active";
                        item.Cells[COL2_STATE].Style.BackColor = Color.Red;
                    }
                   
                }
                

            }
        }


    }
}
