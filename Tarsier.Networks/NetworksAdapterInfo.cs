using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using static Tarsier.Networks.NativeMethods;

namespace Tarsier.Networks {
    public class NetworksAdapterInfo {

        public NetworksAdapterInfo() {

        }
        public List<string> GetNetworkComputerNames() {
            List<string> list = new List<string>();
            int num = 1;
            int num2 = 2;
            IntPtr zero = IntPtr.Zero;
            IntPtr ptr = IntPtr.Zero;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = Marshal.SizeOf(typeof(_SERVER_INFO_100));
            try {
                int num7 = NetServerEnum(null, 100, ref zero, -1, out num3, out num4, num | num2, null, out num5);
                if(num7 == 0) {
                    for(int i = 0; i < num4; i++) {
                        ptr = new IntPtr((int)zero + i * num6);
                        list.Add(((_SERVER_INFO_100)System.Runtime.InteropServices.Marshal.PtrToStructure(ptr, typeof(_SERVER_INFO_100))).sv100_name);
                    }
                }
            } catch(Exception ex) {
                throw ex;
            } finally {
                NetApiBufferFree(zero);
            }
            return list;
        }
        public List<AdapterInfo> GetNetworkAdapterInformation() {
            List<AdapterInfo> networks = new List<AdapterInfo>();
            List<string> networkComputerNames = GetNetworkComputerNames();
            int num = 1;
            foreach(string current in networkComputerNames) {
                IPHostEntry hostEntry = Dns.GetHostEntry(current);
                IPAddress[] addressList = hostEntry.AddressList;
                for(int i = 0; i < addressList.Length; i++) {
                    IPAddress iPAddress = addressList[i];
                    if(iPAddress.AddressFamily.ToString() == "InterNetwork") {
                        networks.Add(new AdapterInfo() {
                            Index = num++,
                            IP = iPAddress.ToString(),
                            Name = current
                        });
                    }
                }
            }
            return networks;
        }

        public List<AdapterInfo> GetNetworkGUIDInformation() {
            List<AdapterInfo> networks = new List<AdapterInfo>();
            RegistryKey start = Registry.LocalMachine;
            RegistryKey cardServiceName;
            string networkcardKey = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkCards";
            string networkcardKeyName, deviceName, deviceServiceName;

            RegistryKey serviceNames = start.OpenSubKey(networkcardKey);
            if(serviceNames == null) {
                //Console.WriteLine("Bad registry key");
                return new List<AdapterInfo>();
            }

            string[] networkCards = serviceNames.GetSubKeyNames();
            serviceNames.Close();

            int index = 0;
            foreach(string keyName in networkCards) {
                networkcardKeyName = networkcardKey + "\\" + keyName;
                cardServiceName = start.OpenSubKey(networkcardKeyName);
                if(cardServiceName == null) {
                    //Console.WriteLine("Bad registry key: {0}", networkcardKeyName);
                    return new List<AdapterInfo>();
                }
                deviceServiceName = (string)cardServiceName.GetValue("ServiceName");
                deviceName = (string)cardServiceName.GetValue("Description");
                networks.Add(new AdapterInfo() {
                    Index = index++,
                    IP = deviceServiceName.ToString(),
                    Name = deviceName
                });
            }
            start.Close();

            return networks;
        }
    }
}