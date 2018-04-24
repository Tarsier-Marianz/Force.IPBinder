using Force.IPBinder.Constants;
using Force.IPBinder.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Force.IPBinder {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Configs _cfgs = new Configs(BindingFile.DatabaseFile);
            bool xpLook = _cfgs.Get<bool>("XPLook");
            if(!xpLook) {
                Application.EnableVisualStyles();
            }
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IPBinderForm());
        }
    }
}
