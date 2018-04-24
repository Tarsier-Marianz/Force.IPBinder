using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Force.IPBinder.Forms {
    public partial class LoginForm : Form {
        public string Password {
            get {
                return txtConfirmPassword.Text.Trim();
            }
        }
        public LoginForm() {
            InitializeComponent();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e) {
            btnSave.Enabled = txtConfirmPassword.Text.Trim().Length > 2;
        }

        private void txtConfirmPassword_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode.Equals(Keys.Enter)) {
                btnSave.PerformClick();
            }
        }
    }
}
