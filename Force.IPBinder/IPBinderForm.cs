using Force.IPBinder.Enums;
using Force.IPBinder.Forms;
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

        private void Action(string tag) {
            switch(tag) {
                case "ADD":
                    
                    break;
                case "REMOVE":
                    if(!string.IsNullOrEmpty("")) {
                       // if(MessageBox.Show(Messages.REMOVE, "Remove Credential", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes)) {
                           
                        //}
                    }
                    break;
                case "CLEAR":
                   // if(MessageBox.Show(Messages.CLEAR, "Clear Credentials", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes)) {
                       
                   // }
                    break;
                case "OPTIONS":
                    using(OptionForm opt = new OptionForm()) {
                        opt.ShowDialog();
                    }
                    break;
                case "HELP":
                    using(HelpForm h = new HelpForm()) {
                        h.ShowDialog();
                    }
                    break;
                case "EXIT":
                    Close();
                    break;
                case "ABOUT":
                    using(AboutForm a = new AboutForm()) {
                        a.ShowDialog();
                    }
                    break;
                case "Toolbar":
                    //RegConfig.Set<bool>("Toolbar", menuToolbar.Checked);
                    //toolStripPwd.Visible = menuToolbar.Checked;
                    break;
                case "Statusbar":
                    //RegConfig.Set<bool>("Statusbar", menuStatus.Checked);
                    //statusStripPwd.Visible = menuStatus.Checked;
                    break;
                case "XPLOOK":
                    //RegConfig.Set<bool>("XPLook", menuXPLook.Checked);
                    Application.Restart();
                    break;
                default:
                    break;
            }
        }
        private void IPBinderForm_Load(object sender, EventArgs e) {
            InitializeNetLocale();
        }

        private void cboxLocales_SelectedIndexChanged(object sender, EventArgs e) {
            InitializeIPs((NetworkLocale)cboxLocales.SelectedIndex);
        }
       

        private void Menus_Click(object sender, EventArgs e) {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            if(menu != null) {
                if(menu.Tag != null) {
                    Action(menu.Tag.ToString());
                }
            }
        }

        private void Buttons_Click(object sender, EventArgs e) {
            ToolStripButton tbtn = sender as ToolStripButton;
            if(tbtn != null) {
                if(tbtn.Tag != null) {
                    Action(tbtn.Tag.ToString());
                }
            } else {
                Button btn = sender as Button;
                if(btn != null) {
                    if(btn.Tag != null) {
                        Action(btn.Tag.ToString());
                    }
                }
            }
        }
      
    }
}