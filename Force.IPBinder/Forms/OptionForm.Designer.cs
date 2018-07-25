﻿namespace Force.IPBinder.Forms {
    partial class OptionForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
            this.chkClearBindList = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkSetPassword = new System.Windows.Forms.CheckBox();
            this.linkChange = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.chkOperationalStatus = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkAutoSelecteArch = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageAppearance = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.chkEnterCmd = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFont = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownPingCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageAdmin = new System.Windows.Forms.TabPage();
            this.chkKillProcess = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageAppearance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingCount)).BeginInit();
            this.tabPageAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkClearBindList
            // 
            this.chkClearBindList.ForeColor = System.Drawing.Color.Green;
            this.chkClearBindList.Location = new System.Drawing.Point(17, 72);
            this.chkClearBindList.Name = "chkClearBindList";
            this.chkClearBindList.Size = new System.Drawing.Size(292, 17);
            this.chkClearBindList.TabIndex = 2;
            this.chkClearBindList.Tag = "ClearBindList";
            this.chkClearBindList.Text = "Clear Bind List";
            this.chkClearBindList.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(35, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clear all binded list during window startup.";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(35, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password protection before opening application.";
            // 
            // chkSetPassword
            // 
            this.chkSetPassword.ForeColor = System.Drawing.Color.Green;
            this.chkSetPassword.Location = new System.Drawing.Point(17, 184);
            this.chkSetPassword.Name = "chkSetPassword";
            this.chkSetPassword.Size = new System.Drawing.Size(277, 17);
            this.chkSetPassword.TabIndex = 4;
            this.chkSetPassword.Tag = "SetPassword";
            this.chkSetPassword.Text = "Set Password";
            this.chkSetPassword.UseVisualStyleBackColor = true;
            this.chkSetPassword.CheckedChanged += new System.EventHandler(this.chkSetPassword_CheckedChanged);
            // 
            // linkChange
            // 
            this.linkChange.AutoSize = true;
            this.linkChange.Location = new System.Drawing.Point(300, 188);
            this.linkChange.Name = "linkChange";
            this.linkChange.Size = new System.Drawing.Size(44, 13);
            this.linkChange.TabIndex = 8;
            this.linkChange.TabStop = true;
            this.linkChange.Text = "Change";
            this.linkChange.Visible = false;
            this.linkChange.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChange_LinkClicked);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(35, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Display all network interface with with UP operational status.";
            // 
            // chkOperationalStatus
            // 
            this.chkOperationalStatus.ForeColor = System.Drawing.Color.Green;
            this.chkOperationalStatus.Location = new System.Drawing.Point(17, 123);
            this.chkOperationalStatus.Name = "chkOperationalStatus";
            this.chkOperationalStatus.Size = new System.Drawing.Size(292, 17);
            this.chkOperationalStatus.TabIndex = 9;
            this.chkOperationalStatus.Tag = "OperationalStatus";
            this.chkOperationalStatus.Text = "Operational Status Only";
            this.chkOperationalStatus.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageAdmin);
            this.tabControl1.Controls.Add(this.tabPageAppearance);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(365, 275);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkAutoSelecteArch);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.chkClearBindList);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.chkOperationalStatus);
            this.tabPage1.Controls.Add(this.chkSetPassword);
            this.tabPage1.Controls.Add(this.linkChange);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(357, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkAutoSelecteArch
            // 
            this.chkAutoSelecteArch.ForeColor = System.Drawing.Color.Green;
            this.chkAutoSelecteArch.Location = new System.Drawing.Point(17, 13);
            this.chkAutoSelecteArch.Name = "chkAutoSelecteArch";
            this.chkAutoSelecteArch.Size = new System.Drawing.Size(292, 17);
            this.chkAutoSelecteArch.TabIndex = 12;
            this.chkAutoSelecteArch.Tag = "AutoSelectArchitecture";
            this.chkAutoSelecteArch.Text = "Auto Select Architecture";
            this.chkAutoSelecteArch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Automatically select ForceBindIP depending on Operating System architecture";
            // 
            // tabPageAppearance
            // 
            this.tabPageAppearance.Controls.Add(this.label10);
            this.tabPageAppearance.Controls.Add(this.numericUpDownDelay);
            this.tabPageAppearance.Controls.Add(this.label11);
            this.tabPageAppearance.Controls.Add(this.chkEnterCmd);
            this.tabPageAppearance.Controls.Add(this.label9);
            this.tabPageAppearance.Controls.Add(this.btnFont);
            this.tabPageAppearance.Controls.Add(this.label8);
            this.tabPageAppearance.Controls.Add(this.btnColor);
            this.tabPageAppearance.Controls.Add(this.label7);
            this.tabPageAppearance.Controls.Add(this.label6);
            this.tabPageAppearance.Controls.Add(this.numericUpDownPingCount);
            this.tabPageAppearance.Controls.Add(this.label5);
            this.tabPageAppearance.Location = new System.Drawing.Point(4, 22);
            this.tabPageAppearance.Name = "tabPageAppearance";
            this.tabPageAppearance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAppearance.Size = new System.Drawing.Size(357, 249);
            this.tabPageAppearance.TabIndex = 1;
            this.tabPageAppearance.Text = "Miscellaneous";
            this.tabPageAppearance.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(133, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 31);
            this.label10.TabIndex = 24;
            this.label10.Text = "Time latency (milliseconds) before displaying cmd response per line.";
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.Location = new System.Drawing.Point(136, 74);
            this.numericUpDownDelay.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.Size = new System.Drawing.Size(96, 21);
            this.numericUpDownDelay.TabIndex = 23;
            this.numericUpDownDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Response Delay:";
            // 
            // chkEnterCmd
            // 
            this.chkEnterCmd.AutoSize = true;
            this.chkEnterCmd.Location = new System.Drawing.Point(133, 221);
            this.chkEnterCmd.Name = "chkEnterCmd";
            this.chkEnterCmd.Size = new System.Drawing.Size(145, 17);
            this.chkEnterCmd.TabIndex = 21;
            this.chkEnterCmd.Tag = "ShowEnterCmd";
            this.chkEnterCmd.Text = "Show entered command.";
            this.chkEnterCmd.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Command Line";
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(133, 182);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(195, 23);
            this.btnFont.TabIndex = 19;
            this.btnFont.Text = "Courier New";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Font:";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(133, 153);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(195, 23);
            this.btnColor.TabIndex = 17;
            this.btnColor.Text = "White";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Color:";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(133, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Number of response when IP Address being ping.\r\nValue should be 4 up to 100.";
            // 
            // numericUpDownPingCount
            // 
            this.numericUpDownPingCount.Location = new System.Drawing.Point(136, 16);
            this.numericUpDownPingCount.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownPingCount.Name = "numericUpDownPingCount";
            this.numericUpDownPingCount.Size = new System.Drawing.Size(96, 21);
            this.numericUpDownPingCount.TabIndex = 1;
            this.numericUpDownPingCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ping Count:";
            // 
            // tabPageAdmin
            // 
            this.tabPageAdmin.Controls.Add(this.label13);
            this.tabPageAdmin.Controls.Add(this.pictureBox1);
            this.tabPageAdmin.Controls.Add(this.chkKillProcess);
            this.tabPageAdmin.Controls.Add(this.label12);
            this.tabPageAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdmin.Name = "tabPageAdmin";
            this.tabPageAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdmin.Size = new System.Drawing.Size(357, 249);
            this.tabPageAdmin.TabIndex = 2;
            this.tabPageAdmin.Text = "Administrative";
            this.tabPageAdmin.UseVisualStyleBackColor = true;
            // 
            // chkKillProcess
            // 
            this.chkKillProcess.ForeColor = System.Drawing.Color.Green;
            this.chkKillProcess.Location = new System.Drawing.Point(22, 23);
            this.chkKillProcess.Name = "chkKillProcess";
            this.chkKillProcess.Size = new System.Drawing.Size(292, 17);
            this.chkKillProcess.TabIndex = 14;
            this.chkKillProcess.Tag = "KillProcess";
            this.chkKillProcess.Text = "Kill Process";
            this.chkKillProcess.UseVisualStyleBackColor = true;
            this.chkKillProcess.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(43, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(292, 31);
            this.label12.TabIndex = 15;
            this.label12.Text = "When application is close it will automatically close all active proccesses if fo" +
    "und such PING, cmd , etc.";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(302, 302);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(221, 302);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Apply";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Force.IPBinder.Properties.Resources.warning_icon;
            this.pictureBox1.Location = new System.Drawing.Point(21, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label13
            // 
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(43, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(292, 48);
            this.label13.TabIndex = 17;
            this.label13.Text = "If you know what you are doing, please consider the following risk: processes eve" +
    "n if not opened or associated of this application may be killed also.";
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 340);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageAppearance.ResumeLayout(false);
            this.tabPageAppearance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingCount)).EndInit();
            this.tabPageAdmin.ResumeLayout(false);
            this.tabPageAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox chkClearBindList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkSetPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel linkChange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkOperationalStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkAutoSelecteArch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageAppearance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownPingCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkEnterCmd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownDelay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPageAdmin;
        private System.Windows.Forms.CheckBox chkKillProcess;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
    }
}