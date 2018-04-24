using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Force.IPBinder.Helpers {
    public class ForceBind {
        private string ForceBindIPx86 = Path.Combine(Application.StartupPath, "ForceBindIP", "ForceBindIP.exe");
        private string ForceBindIPx64 = Path.Combine(Application.StartupPath, "ForceBindIP", "ForceBindIP64.exe");
        private string BindIP_DLLx86 = Path.Combine(Application.StartupPath, "ForceBindIP", "BindIP.exe");
        private string BindIP_DLLx64 = Path.Combine(Application.StartupPath, "ForceBindIP", "BindIP64.exe");

        private string _useForceBindIPFile = string.Empty;
        public ForceBind() {
           
            if (!File.Exists(ForceBindIPx86)) {
                throw new ArgumentNullException(ForceBindIPx86);
            }
            if (!File.Exists(BindIP_DLLx86)) {
                throw new ArgumentNullException(BindIP_DLLx86);
            }

            if (!File.Exists(ForceBindIPx64)) {
                throw new ArgumentNullException(ForceBindIPx64);
            } if (!File.Exists(BindIP_DLLx64)) {
                throw new ArgumentNullException(BindIP_DLLx64);
            }

       }

       public bool StartBind(string filename, string arguments) {
           try {
               if (!File.Exists(filename)) {
                   throw new ArgumentNullException(filename);
               }


           } catch {
               return false;
           }
           return true;
       }
    }
}
