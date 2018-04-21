using Force.IPBinder.Enums;
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
using Tarsier.Networks;

namespace Force.IPBinder {
    public partial class IPBinderForm : Form {
        private NetworksAdapterInfo _networkInfo;
        public IPBinderForm() {
            InitializeComponent();
        }

        private void InitializeNetLocale() {
            cboxLocales.Items.Clear();
            string[] locales = new string[] { "None", "Local Network Device -IP Address", "Local Network Device -GUID", "Intranet Network Information" };
            foreach(string l in locales) {
                cboxLocales.Items.Add(l);
            }
            cboxLocales.SelectedIndex = 0;
        }
        private void InitializeIPs(NetworkLocale locale) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                cboxIPAddress.Items.Clear();
                cboxIPAddress.DropDownStyle = ComboBoxStyle.DropDownList;

                if(locale == NetworkLocale.Network) {
                    _networkInfo = new NetworksAdapterInfo();
                    foreach(AdapterInfo info in _networkInfo.GetNetworkAdapterInformation()) {
                        cboxIPAddress.Items.Add(info.Name + " @ " + info.IP);
                    }
                    cboxIPAddress.SelectedIndex = 0;
                    lblIPAdd.Text = "      Computer IP:";
                    lblIPAdd.ImageIndex = 9;
                } else if(locale == NetworkLocale.LocalIP) {
                    NetworkInterface[] ifaceList = NetworkInterface.GetAllNetworkInterfaces();
                    foreach(NetworkInterface iface in ifaceList) {
                        if(iface.OperationalStatus == OperationalStatus.Up) {
                            UnicastIPAddressInformationCollection unicastIPC = iface.GetIPProperties().UnicastAddresses;
                            foreach(UnicastIPAddressInformation unicast in unicastIPC) {
                                if(unicast.Address.AddressFamily == AddressFamily.InterNetwork) {
                                    cboxIPAddress.Items.Add(iface.Description + " @ " + unicast.Address);
                                }
                            }
                        }
                    }
                    cboxIPAddress.SelectedIndex = 0;
                    lblIPAdd.Text = "      Network Card IP:";
                    lblIPAdd.ImageIndex = 3;
                } else if(locale == NetworkLocale.LocalGUID) {
                    _networkInfo = new NetworksAdapterInfo();
                    foreach(AdapterInfo info in _networkInfo.GetNetworkGUIDInformation()) {
                        cboxIPAddress.Items.Add(info.Name + " @ " + info.IP);
                    }
                    cboxIPAddress.SelectedIndex = 0;
                    lblIPAdd.Text = "      Network Card GUID:";
                    lblIPAdd.ImageIndex = 3;
                } else {
                    cboxIPAddress.DropDownStyle = ComboBoxStyle.Simple;
                    lblIPAdd.Text = "      Enter IP Address:";
                    lblIPAdd.ImageIndex = 6;
                }
            } catch {

            } finally {
                Cursor.Current = Cursors.Default;
            }
        }
        private void IPBinderForm_Load(object sender, EventArgs e) {
            InitializeNetLocale();
        }

        private void cboxLocales_SelectedIndexChanged(object sender, EventArgs e) {
            InitializeIPs((NetworkLocale)cboxLocales.SelectedIndex);
        }

        private void toolStripButton2_Click(object sender, EventArgs e) {

        }
    }
}