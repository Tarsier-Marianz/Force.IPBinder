using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Force.IPBinder.Forms {
    public partial class PasswordForm : Form {
        private string _currentPassword = string.Empty;
        public string Password {
            get {
                return txtConfirmPassword.Text.Trim();
            }
        }
        public PasswordForm(string currentPassword) {
            InitializeComponent();
            InitPassword(currentPassword);
        }

        private void InitPassword(string currentPassword) {
            _currentPassword = currentPassword;
            if(string.IsNullOrEmpty(_currentPassword)) {
                lblCurrentPwd.Visible = txtCurrentPassword.Visible = false;
                txtPassword.Enabled = txtConfirmPassword.Enabled = true;
            } else {
                lblCurrentPwd.Visible = txtCurrentPassword.Visible = true;
                txtPassword.Enabled = txtConfirmPassword.Enabled = false;
            }
        }

        private void timerCheck_Tick(object sender, EventArgs e) {
            if(string.IsNullOrEmpty(_currentPassword)) {
                btnSave.Enabled = txtPassword.Text.Trim().Length > 2 && txtPassword.Text.Equals(txtConfirmPassword.Text);
            }else {
                txtPassword.Enabled = txtCurrentPassword.Text.Equals(_currentPassword);
                txtConfirmPassword.Enabled = txtPassword.Text.Trim().Length > 2;
                btnSave.Enabled = _currentPassword.Equals(txtCurrentPassword.Text) && txtPassword.Text.Trim().Length > 2 && txtPassword.Text.Equals(txtConfirmPassword.Text);
            }
        }

        private void Password_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode.Equals(Keys.Enter)) {
                if(btnSave.Enabled) {
                    btnSave.PerformClick();
                }else {
                    SendKeys.Send("{TAB}");
                }
            }
        }
    }
}
