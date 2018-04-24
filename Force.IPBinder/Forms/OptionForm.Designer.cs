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
            this.chkEncryptContent = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkClearBindList = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkSetPassword = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.linkChange = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.chkOperationalStatus = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkEncryptContent
            // 
            this.chkEncryptContent.Checked = true;
            this.chkEncryptContent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEncryptContent.Enabled = false;
            this.chkEncryptContent.ForeColor = System.Drawing.Color.Green;
            this.chkEncryptContent.Location = new System.Drawing.Point(23, 26);
            this.chkEncryptContent.Name = "chkEncryptContent";
            this.chkEncryptContent.Size = new System.Drawing.Size(292, 17);
            this.chkEncryptContent.TabIndex = 0;
            this.chkEncryptContent.Tag = "Encrypt";
            this.chkEncryptContent.Text = "Encrypt";
            this.chkEncryptContent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(41, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encrypt all data stored into database. This will help to secure database content." +
    "";
            // 
            // chkClearBindList
            // 
            this.chkClearBindList.ForeColor = System.Drawing.Color.Green;
            this.chkClearBindList.Location = new System.Drawing.Point(23, 84);
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
            this.label2.Location = new System.Drawing.Point(41, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clear all binded list during window startup.";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(41, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password protection before opening application.";
            // 
            // chkSetPassword
            // 
            this.chkSetPassword.ForeColor = System.Drawing.Color.Green;
            this.chkSetPassword.Location = new System.Drawing.Point(23, 196);
            this.chkSetPassword.Name = "chkSetPassword";
            this.chkSetPassword.Size = new System.Drawing.Size(292, 17);
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
            this.btnCancel.Location = new System.Drawing.Point(275, 258);
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
            this.btnSave.Location = new System.Drawing.Point(194, 258);
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
            this.linkChange.Location = new System.Drawing.Point(306, 200);
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
            this.label4.Location = new System.Drawing.Point(41, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Display all network interface with with UP operational status.";
            // 
            // chkOperationalStatus
            // 
            this.chkOperationalStatus.ForeColor = System.Drawing.Color.Green;
            this.chkOperationalStatus.Location = new System.Drawing.Point(23, 135);
            this.chkOperationalStatus.Name = "chkOperationalStatus";
            this.chkOperationalStatus.Size = new System.Drawing.Size(292, 17);
            this.chkOperationalStatus.TabIndex = 9;
            this.chkOperationalStatus.Tag = "OperationalStatus";
            this.chkOperationalStatus.Text = "Operational Status Only";
            this.chkOperationalStatus.UseVisualStyleBackColor = true;
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 306);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkOperationalStatus);
            this.Controls.Add(this.linkChange);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkSetPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkClearBindList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkEncryptContent);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEncryptContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkClearBindList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkSetPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel linkChange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkOperationalStatus;
    }
}