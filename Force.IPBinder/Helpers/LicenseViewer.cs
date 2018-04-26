using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Force.IPBinder.Helpers {
    public class LicenseViewer {
        private static string _licenseFile = "license.txt";

        public static string GetContent() {
            string _filename = Path.Combine(Application.StartupPath, _licenseFile);
            string content = string.Empty;
            if(File.Exists(_filename)) {
                using(StreamReader sr = new StreamReader(_filename)) {
                    content = sr.ReadToEnd();
                }
            }
            return content;
        }
    }

    public class ChangedLogViewer {
        private static string _changelogFile = "changelog.txt";

        public static string GetContent() {
            string _filename = Path.Combine(Application.StartupPath, _changelogFile);
            string content = string.Empty;
            if(File.Exists(_filename)) {
                using(StreamReader sr = new StreamReader(_filename)) {
                    content = sr.ReadToEnd();
                }
            }
            return content;
        }
    }

}
