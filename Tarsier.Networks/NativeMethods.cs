using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Tarsier.Networks {
    public class NativeMethods {
        [DllImport("Iphlpapi.dll")]
        public static extern uint GetAdaptersAddresses(uint Family, uint flags, IntPtr Reserved, IntPtr PAdaptersAddresses, ref uint pOutBufLen);

    }
}