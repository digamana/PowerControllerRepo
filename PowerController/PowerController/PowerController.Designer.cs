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
            this.components = new System.ComponentModel.Container();
            ComponentFactory.Krypton.Toolkit.KryptonLabel lblExecuting;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkActive = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.chkAutoOpen = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kryptonCommand1 = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.cmbExecuting = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTurnOn = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpen = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtbActive = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonComboBox3 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonComboBox2 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtbIdle = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonComboBox5 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonComboBox4 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblCD = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWake = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            lblExecuting = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox4)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.98925F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.01075F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1273, 538);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chkActive);
            this.flowLayoutPanel1.Controls.Add(this.pBar1);
            this.flowLayoutPanel1.Controls.Add(this.chkAutoOpen);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel8);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(729, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(458, 274);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // chkActive
            // 
            this.chkActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chkActive.DropDownWidth = 121;
            this.chkActive.Location = new System.Drawing.Point(3, 3);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(122, 29);
            this.chkActive.TabIndex = 2;
            this.chkActive.SelectedIndexChanged += new System.EventHandler(this.chkActive_SelectedIndexChanged);
            // 
            // pBar1
            // 
            this.pBar1.Location = new System.Drawing.Point(131, 3);
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(100, 22);
            this.pBar1.TabIndex = 3;
            // 
            // chkAutoOpen
            // 
            this.chkAutoOpen.AutoSize = true;
            this.chkAutoOpen.Location = new System.Drawing.Point(238, 4);
            this.chkAutoOpen.Margin = new System.Windows.Forms.Padding(4);
            this.chkAutoOpen.Name = "chkAutoOpen";
            this.chkAutoOpen.Size = new System.Drawing.Size(127, 22);
            this.chkAutoOpen.TabIndex = 1;
            this.chkAutoOpen.Text = "chkAutoOpen";
            this.chkAutoOpen.UseVisualStyleBackColor = true;
            this.chkAutoOpen.CheckedChanged += new System.EventHandler(this.chkAutoOpen_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.progressBar2, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(4, 39);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(255, 44);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(4, 4);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(119, 34);
            this.progressBar2.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.progressBar3, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.cmbExecuting, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 91);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(255, 87);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(4, 47);
            this.progressBar3.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(150, 34);
            this.progressBar3.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kryptonCommand1
            // 
            this.kryptonCommand1.Text = "kryptonCommand1";
            // 
            // cmbExecuting
            // 
            this.cmbExecuting.Location = new System.Drawing.Point(3, 3);
            this.cmbExecuting.Name = "cmbExecuting";
            this.cmbExecuting.Size = new System.Drawing.Size(157, 29);
            this.cmbExecuting.TabIndex = 2;
            this.cmbExecuting.Values.Text = "When Executing";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(204, 4);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(503, 11);
            this.progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // cmbTurnOn
            // 
            this.cmbTurnOn.Location = new System.Drawing.Point(3, 350);
            this.cmbTurnOn.Name = "cmbTurnOn";
            this.cmbTurnOn.Size = new System.Drawing.Size(260, 29);
            this.cmbTurnOn.TabIndex = 3;
            this.cmbTurnOn.Values.Text = "Turn on Computer Executing  ";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel5.Controls.Add(lblExecuting, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.kryptonComboBox1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtbIdle, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.kryptonComboBox2, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.kryptonComboBox3, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtbActive, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnOpen, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 79);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(709, 147);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(512, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(194, 42);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Values.Text = "Set Application Item";
            // 
            // txtbActive
            // 
            this.txtbActive.Location = new System.Drawing.Point(4, 54);
            this.txtbActive.Margin = new System.Windows.Forms.Padding(4);
            this.txtbActive.Name = "txtbActive";
            this.txtbActive.Size = new System.Drawing.Size(115, 29);
            this.txtbActive.TabIndex = 0;
            this.txtbActive.Values.Text = "When Active";
            // 
            // kryptonComboBox3
            // 
            this.kryptonComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox3.DropDownWidth = 121;
            this.kryptonComboBox3.Location = new System.Drawing.Point(204, 54);
            this.kryptonComboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonComboBox3.Name = "kryptonComboBox3";
            this.kryptonComboBox3.Size = new System.Drawing.Size(182, 29);
            this.kryptonComboBox3.TabIndex = 1;
            // 
            // kryptonComboBox2
            // 
            this.kryptonComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox2.DropDownWidth = 121;
            this.kryptonComboBox2.Location = new System.Drawing.Point(204, 104);
            this.kryptonComboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonComboBox2.Name = "kryptonComboBox2";
            this.kryptonComboBox2.Size = new System.Drawing.Size(182, 29);
            this.kryptonComboBox2.TabIndex = 2;
            // 
            // txtbIdle
            // 
            this.txtbIdle.Location = new System.Drawing.Point(4, 104);
            this.txtbIdle.Margin = new System.Windows.Forms.Padding(4);
            this.txtbIdle.Name = "txtbIdle";
            this.txtbIdle.Size = new System.Drawing.Size(96, 29);
            this.txtbIdle.TabIndex = 0;
            this.txtbIdle.Values.Text = "When Idle";
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox1.DropDownWidth = 121;
            this.kryptonComboBox1.Location = new System.Drawing.Point(204, 4);
            this.kryptonComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(182, 29);
            this.kryptonComboBox1.TabIndex = 2;
            // 
            // lblExecuting
            // 
            lblExecuting.Location = new System.Drawing.Point(4, 4);
            lblExecuting.Margin = new System.Windows.Forms.Padding(4);
            lblExecuting.Name = "lblExecuting";
            lblExecuting.Size = new System.Drawing.Size(144, 29);
            lblExecuting.TabIndex = 3;
            lblExecuting.Values.Text = "When Executing";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.lblCD, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.kryptonComboBox4, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.kryptonComboBox5, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblWake, 2, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(709, 42);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // kryptonComboBox5
            // 
            this.kryptonComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox5.DropDownWidth = 121;
            this.kryptonComboBox5.Location = new System.Drawing.Point(557, 3);
            this.kryptonComboBox5.Name = "kryptonComboBox5";
            this.kryptonComboBox5.Size = new System.Drawing.Size(149, 29);
            this.kryptonComboBox5.TabIndex = 5;
            // 
            // kryptonComboBox4
            // 
            this.kryptonComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox4.DropDownWidth = 121;
            this.kryptonComboBox4.Location = new System.Drawing.Point(204, 4);
            this.kryptonComboBox4.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonComboBox4.Name = "kryptonComboBox4";
            this.kryptonComboBox4.Size = new System.Drawing.Size(146, 29);
            this.kryptonComboBox4.TabIndex = 3;
            // 
            // lblCD
            // 
            this.lblCD.Location = new System.Drawing.Point(4, 4);
            this.lblCD.Margin = new System.Windows.Forms.Padding(4);
            this.lblCD.Name = "lblCD";
            this.lblCD.Size = new System.Drawing.Size(115, 29);
            this.lblCD.TabIndex = 4;
            this.lblCD.Values.Text = "Count Down";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmbTurnOn, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.71429F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(717, 530);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.progressBar1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(711, 19);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // lblWake
            // 
            this.lblWake.Location = new System.Drawing.Point(357, 3);
            this.lblWake.Name = "lblWake";
            this.lblWake.Size = new System.Drawing.Size(131, 29);
            this.lblWake.TabIndex = 6;
            this.lblWake.Values.Text = "Wake Up Type";
            // 
            // PowerController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 538);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PowerController";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PowerController_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox4)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox chkAutoOpen;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox chkActive;
        private System.Windows.Forms.ProgressBar pBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private ComponentFactory.Krypton.Toolkit.KryptonCommand kryptonCommand1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox cmbExecuting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCD;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel txtbIdle;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel txtbActive;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOpen;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox cmbTurnOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblWake;
    }
}

