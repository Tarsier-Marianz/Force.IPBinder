namespace Force.IPBinder.Forms {
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.linkChange = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.chkOperationalStatus = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPageAppearance = new System.Windows.Forms.TabPage();
            this.chkAutoSelecteArch = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFont = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageAppearance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkClearBindList
            // 
            this.chkClearBindList.ForeColor = System.Drawing.Color.Green;
            this.chkClearBindList.Location = new System.Drawing.Point(17, 65);
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
            this.label2.Location = new System.Drawing.Point(35, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clear all binded list during window startup.";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(35, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password protection before opening application.";
            // 
            // chkSetPassword
            // 
            this.chkSetPassword.ForeColor = System.Drawing.Color.Green;
            this.chkSetPassword.Location = new System.Drawing.Point(17, 177);
            this.chkSetPassword.Name = "chkSetPassword";
            this.chkSetPassword.Size = new System.Drawing.Size(277, 17);
            this.chkSetPassword.TabIndex = 4;
            this.chkSetPassword.Tag = "SetPassword";
            this.chkSetPassword.Text = "Set Password";
            this.chkSetPassword.UseVisualStyleBackColor = true;
            this.chkSetPassword.CheckedChanged += new System.EventHandler(this.chkSetPassword_CheckedChanged);
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
            // linkChange
            // 
            this.linkChange.AutoSize = true;
            this.linkChange.Location = new System.Drawing.Point(300, 181);
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
            this.label4.Location = new System.Drawing.Point(35, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Display all network interface with with UP operational status.";
            // 
            // chkOperationalStatus
            // 
            this.chkOperationalStatus.ForeColor = System.Drawing.Color.Green;
            this.chkOperationalStatus.Location = new System.Drawing.Point(17, 116);
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
            // tabPageAppearance
            // 
            this.tabPageAppearance.Controls.Add(this.label9);
            this.tabPageAppearance.Controls.Add(this.btnFont);
            this.tabPageAppearance.Controls.Add(this.label8);
            this.tabPageAppearance.Controls.Add(this.btnColor);
            this.tabPageAppearance.Controls.Add(this.label7);
            this.tabPageAppearance.Controls.Add(this.label6);
            this.tabPageAppearance.Controls.Add(this.numericUpDown1);
            this.tabPageAppearance.Controls.Add(this.label5);
            this.tabPageAppearance.Location = new System.Drawing.Point(4, 22);
            this.tabPageAppearance.Name = "tabPageAppearance";
            this.tabPageAppearance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAppearance.Size = new System.Drawing.Size(357, 249);
            this.tabPageAppearance.TabIndex = 1;
            this.tabPageAppearance.Text = "Miscellaneous";
            this.tabPageAppearance.UseVisualStyleBackColor = true;
            // 
            // chkAutoSelecteArch
            // 
            this.chkAutoSelecteArch.ForeColor = System.Drawing.Color.Green;
            this.chkAutoSelecteArch.Location = new System.Drawing.Point(17, 6);
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
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Automatically select ForceBindIP depending on Operating System architecture";
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(87, 16);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(96, 21);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(84, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Number of response when IP Address being ping.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Color:";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(133, 99);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(195, 23);
            this.btnColor.TabIndex = 17;
            this.btnColor.Text = "White";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Font:";
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(133, 128);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(195, 23);
            this.btnFont.TabIndex = 19;
            this.btnFont.Text = "Courier New";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Command Line";
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 340);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}