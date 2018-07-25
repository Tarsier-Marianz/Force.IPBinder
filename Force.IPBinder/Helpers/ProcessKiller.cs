using System.Diagnostics;
using System.Linq;

namespace Force.IPBinder.Helpers {
    public class ProcessKiller {

        public static bool DestroyAll() {
            try {
                Kill("PING");
                Kill("cmd");
            } catch {
                return false;
            }
            return true;
        }
        public static bool Kill(string processName) {
            try {
                Process[] process = Process.GetProcesses();
                foreach(var p in process) {
                    if(p.ProcessName.Contains(processName)) {
                        p.Kill();
                    }
                }
            } catch {
                return false;
            }
            return true;
        }
    }
}