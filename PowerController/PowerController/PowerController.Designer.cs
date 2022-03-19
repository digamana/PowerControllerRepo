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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowerController));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbSetIdleTime = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblCD = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbExe = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmbIdle = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblCurretPowerPlan = new System.Windows.Forms.Label();
            this.cmbActive = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnOpenPowerPlan = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnOpen = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblExecuting = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblIdle = new System.Windows.Forms.Label();
            this.lblCurrentPowerPlan = new System.Windows.Forms.Label();
            this.cmbTurnOn = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.proBarIdleCountDown = new System.Windows.Forms.ProgressBar();
            this.lblIdleCountDwon = new System.Windows.Forms.Label();
            this.chkStop = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSetIdleTime)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbExe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIdle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbActive)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmbTurnOn, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.chkStop, 0, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.cmbSetIdleTime, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblCD, 0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // cmbSetIdleTime
            // 
            resources.ApplyResources(this.cmbSetIdleTime, "cmbSetIdleTime");
            this.cmbSetIdleTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetIdleTime.DropDownWidth = 121;
            this.cmbSetIdleTime.Items.AddRange(new object[] {
            resources.GetString("cmbSetIdleTime.Items"),
            resources.GetString("cmbSetIdleTime.Items1"),
            resources.GetString("cmbSetIdleTime.Items2"),
            resources.GetString("cmbSetIdleTime.Items3"),
            resources.GetString("cmbSetIdleTime.Items4"),
            resources.GetString("cmbSetIdleTime.Items5"),
            resources.GetString("cmbSetIdleTime.Items6"),
            resources.GetString("cmbSetIdleTime.Items7"),
            resources.GetString("cmbSetIdleTime.Items8"),
            resources.GetString("cmbSetIdleTime.Items9"),
            resources.GetString("cmbSetIdleTime.Items10"),
            resources.GetString("cmbSetIdleTime.Items11"),
            resources.GetString("cmbSetIdleTime.Items12"),
            resources.GetString("cmbSetIdleTime.Items13")});
            this.cmbSetIdleTime.Name = "cmbSetIdleTime";
            this.cmbSetIdleTime.SelectedIndexChanged += new System.EventHandler(this.cmbSetIdleTime_SelectedIndexChanged);
            // 
            // lblCD
            // 
            resources.ApplyResources(this.lblCD, "lblCD");
            this.lblCD.BackColor = System.Drawing.Color.Aquamarine;
            this.lblCD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCD.Name = "lblCD";
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.cmbExe, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.cmbIdle, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblCurretPowerPlan, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.cmbActive, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnOpenPowerPlan, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.btnOpen, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblExecuting, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblActive, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblIdle, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblCurrentPowerPlan, 1, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // cmbExe
            // 
            resources.ApplyResources(this.cmbExe, "cmbExe");
            this.cmbExe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExe.DropDownWidth = 121;
            this.cmbExe.Name = "cmbExe";
            this.cmbExe.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            // 
            // cmbIdle
            // 
            resources.ApplyResources(this.cmbIdle, "cmbIdle");
            this.cmbIdle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdle.DropDownWidth = 121;
            this.cmbIdle.Name = "cmbIdle";
            this.cmbIdle.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            // 
            // lblCurretPowerPlan
            // 
            resources.ApplyResources(this.lblCurretPowerPlan, "lblCurretPowerPlan");
            this.lblCurretPowerPlan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurretPowerPlan.Name = "lblCurretPowerPlan";
            // 
            // cmbActive
            // 
            resources.ApplyResources(this.cmbActive, "cmbActive");
            this.cmbActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActive.DropDownWidth = 121;
            this.cmbActive.Name = "cmbActive";
            this.cmbActive.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            // 
            // btnOpenPowerPlan
            // 
            resources.ApplyResources(this.btnOpenPowerPlan, "btnOpenPowerPlan");
            this.btnOpenPowerPlan.Name = "btnOpenPowerPlan";
            this.btnOpenPowerPlan.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.btnOpenPowerPlan.Values.ExtraText = resources.GetString("btnOpenPowerPlan.Values.ExtraText");
            this.btnOpenPowerPlan.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("btnOpenPowerPlan.Values.ImageTransparentColor")));
            this.btnOpenPowerPlan.Values.Text = resources.GetString("btnOpenPowerPlan.Values.Text");
            this.btnOpenPowerPlan.Click += new System.EventHandler(this.btnOpenPowerPlan_Click);
            // 
            // btnOpen
            // 
            resources.ApplyResources(this.btnOpen, "btnOpen");
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.btnOpen.Values.ExtraText = resources.GetString("btnOpen.Values.ExtraText");
            this.btnOpen.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("btnOpen.Values.ImageTransparentColor")));
            this.btnOpen.Values.Text = resources.GetString("btnOpen.Values.Text");
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblExecuting
            // 
            resources.ApplyResources(this.lblExecuting, "lblExecuting");
            this.lblExecuting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExecuting.Name = "lblExecuting";
            // 
            // lblActive
            // 
            resources.ApplyResources(this.lblActive, "lblActive");
            this.lblActive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblActive.Name = "lblActive";
            // 
            // lblIdle
            // 
            resources.ApplyResources(this.lblIdle, "lblIdle");
            this.lblIdle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdle.Name = "lblIdle";
            // 
            // lblCurrentPowerPlan
            // 
            resources.ApplyResources(this.lblCurrentPowerPlan, "lblCurrentPowerPlan");
            this.lblCurrentPowerPlan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentPowerPlan.Name = "lblCurrentPowerPlan";
            // 
            // cmbTurnOn
            // 
            resources.ApplyResources(this.cmbTurnOn, "cmbTurnOn");
            this.cmbTurnOn.Name = "cmbTurnOn";
            this.cmbTurnOn.Values.ExtraText = resources.GetString("cmbTurnOn.Values.ExtraText");
            this.cmbTurnOn.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("cmbTurnOn.Values.ImageTransparentColor")));
            this.cmbTurnOn.Values.Text = resources.GetString("cmbTurnOn.Values.Text");
            this.cmbTurnOn.CheckedChanged += new System.EventHandler(this.cmbTurnOn_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.proBarIdleCountDown, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblIdleCountDwon, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // proBarIdleCountDown
            // 
            resources.ApplyResources(this.proBarIdleCountDown, "proBarIdleCountDown");
            this.proBarIdleCountDown.Name = "proBarIdleCountDown";
            // 
            // lblIdleCountDwon
            // 
            resources.ApplyResources(this.lblIdleCountDwon, "lblIdleCountDwon");
            this.lblIdleCountDwon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdleCountDwon.Name = "lblIdleCountDwon";
            // 
            // chkStop
            // 
            resources.ApplyResources(this.chkStop, "chkStop");
            this.chkStop.Name = "chkStop";
            this.chkStop.Values.ExtraText = resources.GetString("chkStop.Values.ExtraText");
            this.chkStop.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("chkStop.Values.ImageTransparentColor")));
            this.chkStop.Values.Text = resources.GetString("chkStop.Values.Text");
            this.chkStop.CheckedChanged += new System.EventHandler(this.chkStop_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.powerPlanToolStripMenuItem,
            this.hideToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.ShowImageMargin = false;
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenu_EventClick);
            // 
            // showToolStripMenuItem
            // 
            resources.ApplyResources(this.showToolStripMenuItem, "showToolStripMenuItem");
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenu_EventClick);
            // 
            // hideToolStripMenuItem
            // 
            resources.ApplyResources(this.hideToolStripMenuItem, "hideToolStripMenuItem");
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenu_EventClick);
            // 
            // powerPlanToolStripMenuItem
            // 
            resources.ApplyResources(this.powerPlanToolStripMenuItem, "powerPlanToolStripMenuItem");
            this.powerPlanToolStripMenuItem.Name = "powerPlanToolStripMenuItem";
            this.powerPlanToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenu_EventClick);
            // 
            // stopToolStripMenuItem
            // 
            resources.ApplyResources(this.stopToolStripMenuItem, "stopToolStripMenuItem");
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenu_EventClick);
            // 
            // PowerController
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PowerController";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PowerController_FormClosing);
            this.Resize += new System.EventHandler(this.PowerController_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSetIdleTime)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbExe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIdle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbActive)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbExe;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbIdle;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbActive;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOpen;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox cmbTurnOn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbSetIdleTime;
        private System.Windows.Forms.Label lblCurretPowerPlan;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOpenPowerPlan;
        private System.Windows.Forms.ProgressBar proBarIdleCountDown;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblCD;
        private System.Windows.Forms.Label lblExecuting;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblIdle;
        private System.Windows.Forms.Label lblCurrentPowerPlan;
        private System.Windows.Forms.Label lblIdleCountDwon;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chkStop;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
    }
}

