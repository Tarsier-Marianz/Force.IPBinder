using Force.IPBinder.Constants;
using Force.IPBinder.Controllers;
using Force.IPBinder.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Force.IPBinder {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string []args) {
            if(args.Length <= 0) {
                Configs _cfgs = new Configs(BindingFile.DatabaseFile);
                bool xpLook = _cfgs.Get<bool>("XPLook");
                if(!xpLook) {
                    Application.EnableVisualStyles();
                }
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new IPBinderForm());
            }else {
                CheckAutoBind();
            }
        }

        private static Bindings _bindings = new Bindings(BindingFile.DatabaseFile);
        private static Configs _cfgs = new Configs(BindingFile.DatabaseFile);
        private static void CheckAutoBind() {
            _bindings = new Bindings(BindingFile.DatabaseFile);
            _cfgs = new Configs(BindingFile.DatabaseFile);
            string forceBindExe = _cfgs.Get<string>("ForceBindIPExe");

            List<BindingIP> bindingIps = _bindings.GetBindings(true);
            if(bindingIps != null) {
                if(bindingIps.Count > 0 && !string.IsNullOrEmpty(forceBindExe)) {
                    foreach(BindingIP bip in bindingIps) {
                        StartUp(forceBindExe, bip.IPAddress, bip.Path);
                    }
                }
            }
        }
      
        private static void StartUp(string forceBindExe, string ipAddress, string applicationPath) {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = string.Format("/C \"{0}\" {1} \"{2}\"", forceBindExe, ipAddress, applicationPath);
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
