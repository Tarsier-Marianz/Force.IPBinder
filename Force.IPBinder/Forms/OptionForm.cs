using System;
using System.Windows.Forms;

namespace Force.IPBinder.Forms {
    public partial class OptionForm : Form {
        public OptionForm() {
            InitializeComponent();
            InitOptions();
        }

        private void InitOptions() {
            //chkEncryptContent.Checked = RegConfig.Get<bool>("Encrypt");
            //chkHidePassword.Checked = RegConfig.Get<bool>("HidePassword");
            //chkShowDetails.Checked = RegConfig.Get<bool>("ShowPanel");
        }
        private void AppyOptions() {
            //RegConfig.Set<bool>("Encrypt", chkEncryptContent.Checked);
            //RegConfig.Set<bool>("HidePassword", chkHidePassword.Checked);
            //RegConfig.Set<bool>("ShowPanel", chkShowDetails.Checked);
        }

        private void btnSave_Click(object sender, EventArgs e) {
            AppyOptions();
            Close();
        }
    }
}