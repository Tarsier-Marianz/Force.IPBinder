﻿using Force.IPBinder.Constants;
using Force.IPBinder.Controllers;
using System;
using System.Windows.Forms;
using Tarsier.Security;

namespace Force.IPBinder.Forms {
    public partial class OptionForm : Form {

        private Configs _cfgs = new Configs(BindingFile.DatabaseFile);

        private string _password = string.Empty;

        public OptionForm() {
            InitializeComponent();
            InitOptions();
        }

        private void InitOptions() {
            _password = _cfgs.Get<string>("MasterPassword");
            if(!string.IsNullOrEmpty(_password)) {
                try {
                    _password = SimpleEncryption.Decrypt(_password);
                } catch {
                    _password = string.Empty;
                }
                linkChange.Visible = (!string.IsNullOrEmpty(_password));
            }
            chkEncryptContent.Checked = _cfgs.Get<bool>("Encrypt");
            chkClearBindList.Checked = _cfgs.Get<bool>("ClearBindList");
            chkSetPassword.Checked = _cfgs.Get<bool>("SetPassword");
            chkOperationalStatus.Checked = _cfgs.Get<bool>("OperationalStatus");
        }
        private void AppyOptions() {
            Cursor.Current = Cursors.WaitCursor;
            _cfgs.Set<bool>("OperationalStatus", chkOperationalStatus.Checked);
            _cfgs.Set<bool>("Encrypt", chkEncryptContent.Checked);
            _cfgs.Set<bool>("ClearBindList", chkClearBindList.Checked);
            _cfgs.Set<bool>("SetPassword", chkSetPassword.Checked);
            Cursor.Current = Cursors.Default;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            AppyOptions();
            Close();
        }

        private void chkSetPassword_CheckedChanged(object sender, EventArgs e) {
            if(chkSetPassword.Checked && string.IsNullOrEmpty(_password)) {
                SetPassword(string.Empty);
            }
        }

        private void linkChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            SetPassword(_password);
        }

        private void SetPassword(string password) {
            using(PasswordForm pwd = new PasswordForm(password)) {
                if(pwd.ShowDialog().Equals(DialogResult.OK)) {
                    Cursor.Current = Cursors.WaitCursor;
                    _cfgs.Set<string>("MasterPassword", SimpleEncryption.Encrypt(pwd.Password));
                    _password = _cfgs.Get<string>("MasterPassword");
                    _password = SimpleEncryption.Decrypt(_password);
                    Cursor.Current = Cursors.Default;
                } else {
                    chkSetPassword.Checked = false;
                }
            }
        }
    }
}