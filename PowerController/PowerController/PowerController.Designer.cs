namespace PowerController
{
    partial class PowerController
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkAutoOpen = new System.Windows.Forms.CheckBox();
            this.chkActive = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 284);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chkAutoOpen);
            this.flowLayoutPanel1.Controls.Add(this.chkActive);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(458, 274);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // chkAutoOpen
            // 
            this.chkAutoOpen.AutoSize = true;
            this.chkAutoOpen.Location = new System.Drawing.Point(4, 4);
            this.chkAutoOpen.Margin = new System.Windows.Forms.Padding(4);
            this.chkAutoOpen.Name = "chkAutoOpen";
            this.chkAutoOpen.Size = new System.Drawing.Size(127, 22);
            this.chkAutoOpen.TabIndex = 1;
            this.chkAutoOpen.Text = "chkAutoOpen";
            this.chkAutoOpen.UseVisualStyleBackColor = true;
            this.chkAutoOpen.CheckedChanged += new System.EventHandler(this.chkAutoOpen_CheckedChanged);
            // 
            // chkActive
            // 
            this.chkActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chkActive.DropDownWidth = 121;
            this.chkActive.Location = new System.Drawing.Point(138, 3);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(121, 29);
            this.chkActive.TabIndex = 2;
            this.chkActive.SelectedIndexChanged += new System.EventHandler(this.chkActive_SelectedIndexChanged);
            // 
            // PowerController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 284);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PowerController";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox chkAutoOpen;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox chkActive;
    }
}

