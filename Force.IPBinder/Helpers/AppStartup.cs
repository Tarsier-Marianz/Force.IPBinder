using Force.IPBinder.Constants;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Force.IPBinder.Helpers {
   public class AppStartup {
        public static void RegisterInStartup(bool isChecked) {
            AppInfo _info = new AppInfo();
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(BindingFile.RegStartupKey, true);
            if(isChecked) {
                registryKey.SetValue(_info.AssemblyTitle, Application.ExecutablePath +" -autobind");
            } else {
                registryKey.DeleteValue(_info.AssemblyTitle);
            }
        }
    }
}
