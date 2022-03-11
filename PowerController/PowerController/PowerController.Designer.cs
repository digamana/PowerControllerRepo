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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbSetIdleTime = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmbWakeUp = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblWake = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbExe = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmbIdle = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmbActive = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnOpen = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmbTurnOn = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.proBarIdleCountDown = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurretStatusTro = new System.Windows.Forms.Label();
            this.lblCurretStatusDetail = new System.Windows.Forms.Label();
            this.lblCurretPowerPlan = new System.Windows.Forms.Label();
            this.btnOpenPowerPlan = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmbCurrentPowerPlan = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkActive = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.chkAutoOpen = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.cmbExecuting = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kryptonCommand1 = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblCD = new System.Windows.Forms.Label();
            this.lblExecuting = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblIdle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSetIdleTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbWakeUp)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbExe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIdle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbActive)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCurrentPowerPlan)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmbTurnOn, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.71429F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(717, 530);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.cmbSetIdleTime, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.cmbWakeUp, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblWake, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblCD, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(709, 42);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // cmbSetIdleTime
            // 
            this.cmbSetIdleTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetIdleTime.DropDownWidth = 121;
            this.cmbSetIdleTime.Items.AddRange(new object[] {
            "00:00:10",
            "00:00:20",
            "00:00:30",
            "00:01:00",
            "00:05:00",
            "00:10:00",
            "00:20:00",
            "00:30:00",
            "01:00:00",
            "02:00:00",
            "03:00:00",
            "04:00:00",
            "05:00:00",
            "06:00:00"});
            this.cmbSetIdleTime.Location = new System.Drawing.Point(204, 4);
            this.cmbSetIdleTime.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSetIdleTime.Name = "cmbSetIdleTime";
            this.cmbSetIdleTime.Size = new System.Drawing.Size(146, 29);
            this.cmbSetIdleTime.TabIndex = 3;
            this.cmbSetIdleTime.SelectedIndexChanged += new System.EventHandler(this.cmbSetIdleTime_SelectedIndexChanged);
            // 
            // cmbWakeUp
            // 
            this.cmbWakeUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWakeUp.DropDownWidth = 121;
            this.cmbWakeUp.Items.AddRange(new object[] {
            "KeyBoard",
            "Mouse",
            "KeyBoard and Mouse"});
            this.cmbWakeUp.Location = new System.Drawing.Point(557, 3);
            this.cmbWakeUp.Name = "cmbWakeUp";
            this.cmbWakeUp.Size = new System.Drawing.Size(149, 29);
            this.cmbWakeUp.TabIndex = 5;
            // 
            // lblWake
            // 
            this.lblWake.Location = new System.Drawing.Point(357, 3);
            this.lblWake.Name = "lblWake";
            this.lblWake.Size = new System.Drawing.Size(131, 29);
            this.lblWake.TabIndex = 6;
            this.lblWake.Values.Text = "Wake Up Type";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel5.Controls.Add(this.cmbExe, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.cmbIdle, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.cmbActive, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnOpen, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblExecuting, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblActive, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblIdle, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 94);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(709, 147);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // cmbExe
            // 
            this.cmbExe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExe.DropDownWidth = 121;
            this.cmbExe.Location = new System.Drawing.Point(204, 4);
            this.cmbExe.Margin = new System.Windows.Forms.Padding(4);
            this.cmbExe.Name = "cmbExe";
            this.cmbExe.Size = new System.Drawing.Size(182, 29);
            this.cmbExe.TabIndex = 2;
            // 
            // cmbIdle
            // 
            this.cmbIdle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdle.DropDownWidth = 121;
            this.cmbIdle.Location = new System.Drawing.Point(204, 104);
            this.cmbIdle.Margin = new System.Windows.Forms.Padding(4);
            this.cmbIdle.Name = "cmbIdle";
            this.cmbIdle.Size = new System.Drawing.Size(182, 29);
            this.cmbIdle.TabIndex = 2;
            // 
            // cmbActive
            // 
            this.cmbActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActive.DropDownWidth = 121;
            this.cmbActive.Location = new System.Drawing.Point(204, 54);
            this.cmbActive.Margin = new System.Windows.Forms.Padding(4);
            this.cmbActive.Name = "cmbActive";
            this.cmbActive.Size = new System.Drawing.Size(182, 29);
            this.cmbActive.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(512, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(194, 42);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Values.Text = "Set Application Item";
            // 
            // cmbTurnOn
            // 
            this.cmbTurnOn.Location = new System.Drawing.Point(3, 359);
            this.cmbTurnOn.Name = "cmbTurnOn";
            this.cmbTurnOn.Size = new System.Drawing.Size(244, 29);
            this.cmbTurnOn.TabIndex = 3;
            this.cmbTurnOn.Values.Text = "Computer Turn on Execute";
            this.cmbTurnOn.CheckedChanged += new System.EventHandler(this.cmbTurnOn_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.proBarIdleCountDown, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(711, 34);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // proBarIdleCountDown
            // 
            this.proBarIdleCountDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proBarIdleCountDown.Location = new System.Drawing.Point(204, 4);
            this.proBarIdleCountDown.Margin = new System.Windows.Forms.Padding(4);
            this.proBarIdleCountDown.Name = "proBarIdleCountDown";
            this.proBarIdleCountDown.Size = new System.Drawing.Size(503, 26);
            this.proBarIdleCountDown.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.lblCurretStatusTro, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblCurretStatusDetail, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblCurretPowerPlan, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnOpenPowerPlan, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.cmbCurrentPowerPlan, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 248);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(711, 105);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // lblCurretStatusTro
            // 
            this.lblCurretStatusTro.AutoSize = true;
            this.lblCurretStatusTro.Location = new System.Drawing.Point(3, 0);
            this.lblCurretStatusTro.Name = "lblCurretStatusTro";
            this.lblCurretStatusTro.Size = new System.Drawing.Size(118, 18);
            this.lblCurretStatusTro.TabIndex = 0;
            this.lblCurretStatusTro.Text = "CurretStatusTro";
            // 
            // lblCurretStatusDetail
            // 
            this.lblCurretStatusDetail.AutoSize = true;
            this.lblCurretStatusDetail.Location = new System.Drawing.Point(145, 0);
            this.lblCurretStatusDetail.Name = "lblCurretStatusDetail";
            this.lblCurretStatusDetail.Size = new System.Drawing.Size(50, 18);
            this.lblCurretStatusDetail.TabIndex = 1;
            this.lblCurretStatusDetail.Text = "label2";
            // 
            // lblCurretPowerPlan
            // 
            this.lblCurretPowerPlan.AutoSize = true;
            this.lblCurretPowerPlan.Location = new System.Drawing.Point(287, 0);
            this.lblCurretPowerPlan.Name = "lblCurretPowerPlan";
            this.lblCurretPowerPlan.Size = new System.Drawing.Size(125, 18);
            this.lblCurretPowerPlan.TabIndex = 2;
            this.lblCurretPowerPlan.Text = "CurretPowerPlan";
            // 
            // btnOpenPowerPlan
            // 
            this.btnOpenPowerPlan.Location = new System.Drawing.Point(571, 3);
            this.btnOpenPowerPlan.Name = "btnOpenPowerPlan";
            this.btnOpenPowerPlan.Size = new System.Drawing.Size(137, 65);
            this.btnOpenPowerPlan.TabIndex = 3;
            this.btnOpenPowerPlan.Values.Text = "OpenPowerPlan";
            this.btnOpenPowerPlan.Click += new System.EventHandler(this.btnOpenPowerPlan_Click);
            // 
            // cmbCurrentPowerPlan
            // 
            this.cmbCurrentPowerPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrentPowerPlan.DropDownWidth = 121;
            this.cmbCurrentPowerPlan.Location = new System.Drawing.Point(429, 3);
            this.cmbCurrentPowerPlan.Name = "cmbCurrentPowerPlan";
            this.cmbCurrentPowerPlan.Size = new System.Drawing.Size(121, 29);
            this.cmbCurrentPowerPlan.TabIndex = 4;
            this.cmbCurrentPowerPlan.SelectedIndexChanged += new System.EventHandler(this.cmbCurrentPowerPlan_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chkActive);
            this.flowLayoutPanel1.Controls.Add(this.pBar1);
            this.flowLayoutPanel1.Controls.Add(this.chkAutoOpen);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel8);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel6);
            this.flowLayoutPanel1.Controls.Add(this.label1);
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
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
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
            // cmbExecuting
            // 
            this.cmbExecuting.Location = new System.Drawing.Point(3, 3);
            this.cmbExecuting.Name = "cmbExecuting";
            this.cmbExecuting.Size = new System.Drawing.Size(157, 29);
            this.cmbExecuting.TabIndex = 2;
            this.cmbExecuting.Values.Text = "When Executing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
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
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblCD
            // 
            this.lblCD.AutoSize = true;
            this.lblCD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCD.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCD.Location = new System.Drawing.Point(3, 0);
            this.lblCD.Name = "lblCD";
            this.lblCD.Size = new System.Drawing.Size(194, 42);
            this.lblCD.TabIndex = 7;
            this.lblCD.Text = "Count Down";
            this.lblCD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExecuting
            // 
            this.lblExecuting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExecuting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExecuting.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblExecuting.Location = new System.Drawing.Point(3, 0);
            this.lblExecuting.Name = "lblExecuting";
            this.lblExecuting.Size = new System.Drawing.Size(194, 50);
            this.lblExecuting.TabIndex = 0;
            this.lblExecuting.Text = "When Executing";
            this.lblExecuting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActive.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblActive.Location = new System.Drawing.Point(3, 50);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(194, 50);
            this.lblActive.TabIndex = 5;
            this.lblActive.Text = "When Active";
            this.lblActive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIdle
            // 
            this.lblIdle.AutoSize = true;
            this.lblIdle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIdle.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblIdle.Location = new System.Drawing.Point(3, 100);
            this.lblIdle.Name = "lblIdle";
            this.lblIdle.Size = new System.Drawing.Size(194, 50);
            this.lblIdle.TabIndex = 6;
            this.lblIdle.Text = "When Idle";
            this.lblIdle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PowerController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 538);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PowerController";
            this.Text = "PowerController";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PowerController_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSetIdleTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbWakeUp)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbExe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIdle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbActive)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCurrentPowerPlan)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
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
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbWakeUp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbExe;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbIdle;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbActive;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOpen;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox cmbTurnOn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblWake;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbSetIdleTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblCurretStatusTro;
        private System.Windows.Forms.Label lblCurretStatusDetail;
        private System.Windows.Forms.Label lblCurretPowerPlan;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOpenPowerPlan;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbCurrentPowerPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar proBarIdleCountDown;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblCD;
        private System.Windows.Forms.Label lblExecuting;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblIdle;
    }
}

