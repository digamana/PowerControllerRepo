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
            this.cmbWakeUp = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblWake = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurretStatusTro = new System.Windows.Forms.Label();
            this.lblCurretStatusDetail = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kryptonCommand1 = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
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
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.cmbSetIdleTime, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.cmbWakeUp, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblWake, 2, 0);
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
            // cmbWakeUp
            // 
            resources.ApplyResources(this.cmbWakeUp, "cmbWakeUp");
            this.cmbWakeUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWakeUp.DropDownWidth = 121;
            this.cmbWakeUp.Items.AddRange(new object[] {
            resources.GetString("cmbWakeUp.Items"),
            resources.GetString("cmbWakeUp.Items1"),
            resources.GetString("cmbWakeUp.Items2")});
            this.cmbWakeUp.Name = "cmbWakeUp";
            // 
            // lblWake
            // 
            resources.ApplyResources(this.lblWake, "lblWake");
            this.lblWake.Name = "lblWake";
            this.lblWake.Values.ExtraText = resources.GetString("lblWake.Values.ExtraText");
            this.lblWake.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("lblWake.Values.ImageTransparentColor")));
            this.lblWake.Values.Text = resources.GetString("lblWake.Values.Text");
            // 
            // lblCD
            // 
            resources.ApplyResources(this.lblCD, "lblCD");
            this.lblCD.BackColor = System.Drawing.Color.LightCyan;
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
            // 
            // cmbIdle
            // 
            resources.ApplyResources(this.cmbIdle, "cmbIdle");
            this.cmbIdle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdle.DropDownWidth = 121;
            this.cmbIdle.Name = "cmbIdle";
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
            // 
            // btnOpenPowerPlan
            // 
            resources.ApplyResources(this.btnOpenPowerPlan, "btnOpenPowerPlan");
            this.btnOpenPowerPlan.Name = "btnOpenPowerPlan";
            this.btnOpenPowerPlan.Values.ExtraText = resources.GetString("btnOpenPowerPlan.Values.ExtraText");
            this.btnOpenPowerPlan.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("btnOpenPowerPlan.Values.ImageTransparentColor")));
            this.btnOpenPowerPlan.Values.Text = resources.GetString("btnOpenPowerPlan.Values.Text");
            this.btnOpenPowerPlan.Click += new System.EventHandler(this.btnOpenPowerPlan_Click);
            // 
            // btnOpen
            // 
            resources.ApplyResources(this.btnOpen, "btnOpen");
            this.btnOpen.Name = "btnOpen";
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
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.lblCurretStatusTro, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblCurretStatusDetail, 1, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // lblCurretStatusTro
            // 
            resources.ApplyResources(this.lblCurretStatusTro, "lblCurretStatusTro");
            this.lblCurretStatusTro.Name = "lblCurretStatusTro";
            // 
            // lblCurretStatusDetail
            // 
            resources.ApplyResources(this.lblCurretStatusDetail, "lblCurretStatusDetail");
            this.lblCurretStatusDetail.Name = "lblCurretStatusDetail";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kryptonCommand1
            // 
            resources.ApplyResources(this.kryptonCommand1, "kryptonCommand1");
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // PowerController
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PowerController";
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
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private ComponentFactory.Krypton.Toolkit.KryptonCommand kryptonCommand1;
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
        private System.Windows.Forms.ProgressBar proBarIdleCountDown;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblCD;
        private System.Windows.Forms.Label lblExecuting;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblIdle;
        private System.Windows.Forms.Label lblCurrentPowerPlan;
        private System.Windows.Forms.Label lblIdleCountDwon;
    }
}

