using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Tarsier.Networks {
    public class NativeMethods {
        public struct _SERVER_INFO_100 {
            public int sv100_platform_id;

            [MarshalAs(UnmanagedType.LPWStr)]
            public string sv100_name;
        }

        public struct SystemTime {
            public ushort Year;
            public ushort Month;
            public ushort DayOfWeek;
            public ushort Day;
            public ushort Hour;
            public ushort Minute;
            public ushort Second;
            public ushort Millisecond;
        }

        [SuppressUnmanagedCodeSecurity]
        [DllImport("Netapi32", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int NetServerEnum(string ServerNane, int dwLevel, ref System.IntPtr pBuf, int dwPrefMaxLen, out int dwEntriesRead, out int dwTotalEntries, int dwServerType, string domain, out int dwResumeHandle);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("Netapi32", SetLastError = true)]
        public static extern int NetApiBufferFree(System.IntPtr pBuf);

        [DllImport("kernel32.dll", EntryPoint = "GetSystemTime", SetLastError = true)]
        public static extern void Win32GetSystemTime(ref SystemTime sysTime);

        [DllImport("kernel32.dll", EntryPoint = "SetSystemTime", SetLastError = true)]
        public static extern bool Win32SetSystemTime(ref SystemTime sysTime);
    }
}