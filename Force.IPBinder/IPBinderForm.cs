using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Force.IPBinder {
    public partial class IPBinderForm : Form {
        public IPBinderForm() {
            InitializeComponent();
        }

        private void InitializeIPs() {
            /*
            var address = NetworkInterface.GetAllNetworkInterfaces()
                .Where(i => i.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                i.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                .SelectMany(i => i.GetIPProperties().UnicastAddresses)
                .Where(a => a.Address.AddressFamily == AddressFamily.InterNetwork)
                .Select(a => a.Address.ToString())
                .ToList();
            
            if(address.Count > 0) {
                foreach(string ip in address) {
                    cboxIPAddress.Items.Add(ip);
                }
            }
            */
            /* Reference : https://goo.gl/1R7BBd */
            foreach(NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces()) {
                if(ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet) {
                    Console.WriteLine(ni.Name);
                    foreach(UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses) {
                        if(ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) {
                            cboxIPAddress.Items.Add(ip.Address.ToString());
                        }
                    }
                }
            }
        }
        private void IPBinderForm_Load(object sender, EventArgs e) {
            InitializeIPs();
        }
    }
}
