﻿using Force.IPBinder.Constants;
using Force.IPBinder.Controllers;
using Force.IPBinder.Enums;
using Force.IPBinder.Forms;
using Force.IPBinder.Helpers;
using Force.IPBinder.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using Tarsier.Networks;
using Tarsier.Security;

namespace Force.IPBinder {
    public partial class IPBinderForm : Form {
        private Configs _cfgs = new Configs(BindingFile.DatabaseFile);
        private Bindings _bindings = new Bindings(BindingFile.DatabaseFile);
        private NetworksAdapterInfo _networkInfo;
        private bool _operationalStatusOnly = false;
        private bool _setPassword = false;
        private string _password = string.Empty;
        private string _selectedId = string.Empty;
        private string _selectedDesc = string.Empty;
        private string _selectedAutoBind = string.Empty;
        public IPBinderForm() {
            InitializeComponent();
        }
        private void InitializeOptions() {
            _cfgs = new Configs(BindingFile.DatabaseFile);
            _setPassword = _cfgs.Get<bool>("SetPassword");
            _operationalStatusOnly = _cfgs.Get<bool>("OperationalStatus");
            menuToolbar.Checked = _cfgs.Get<bool>("Toolbar");
            menuStatusbar.Checked = _cfgs.Get<bool>("Statusbar");
            listViewBind.GridLines = menuGridlines.Checked = _cfgs.Get<bool>("Gridlines");

            menuXPLook.Checked = _cfgs.Get<bool>("XPLook");
            if(menuXPLook.Checked) {
                menuStripBind.RenderMode = ToolStripRenderMode.System;
                toolStripBind.RenderMode = ToolStripRenderMode.System;
            } else {
                menuStripBind.RenderMode = ToolStripRenderMode.Professional;
                toolStripBind.RenderMode = ToolStripRenderMode.Professional;
            }
            _password = _cfgs.Get<string>("MasterPassword");
            _password = SimpleEncryption.Decrypt(_password);

        }

        private void Login() {
            retry:
            if(_setPassword && !string.IsNullOrEmpty(_password)) {
                using(LoginForm login = new LoginForm()) {
                    if(login.ShowDialog().Equals(DialogResult.OK)) {
                        if(!login.Password.Equals(_password)) {
                            goto retry;
                        }
                    } else {
                        Application.Exit();
                    }
                }
            }
        }

        private void InitializeBindings() {
            _bindings = new Bindings(BindingFile.DatabaseFile);
            _bindings.Initialize(listViewBind, false);
            ClearSelection();
        }

        private void InitializeForceBindIPFile() {
            string ForceBindIPx86 = Path.Combine(Application.StartupPath, "ForceBindIP", "ForceBindIP.exe");
            if(File.Exists(ForceBindIPx86)) {
                lblForceBindFind.Text = "Found";
                lblForceBindFind.ForeColor = Color.Green;
            } else {
                lblForceBindFind.Text = "Not Found";
                lblForceBindFind.ForeColor = Color.Red;
            }
        }
        private void InitializeNetLocale() {
            cboxLocales.Items.Clear();
            string[] locales = new string[] { "None", "Local Network Device -IP Address", "Local Network Device -GUID", "Computer Network Information" };
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
                    lblIPAdd.Text = "Computer IP:";
                    lblIPAdd.ImageIndex = 9;
                } else if(locale == NetworkLocale.LocalIP) {
                    NetworkInterface[] ifaceList = NetworkInterface.GetAllNetworkInterfaces();
                    foreach(NetworkInterface iface in ifaceList) {
                        if(_operationalStatusOnly == true) {
                            if(iface.OperationalStatus == OperationalStatus.Up) {
                                UnicastIPAddressInformationCollection unicastIPC = iface.GetIPProperties().UnicastAddresses;
                                foreach(UnicastIPAddressInformation unicast in unicastIPC) {
                                    if(unicast.Address.AddressFamily == AddressFamily.InterNetwork) {
                                        cboxIPAddress.Items.Add(iface.Description + " @ " + unicast.Address);
                                    }
                                }
                            }
                        } else {
                            UnicastIPAddressInformationCollection unicastIPC = iface.GetIPProperties().UnicastAddresses;
                            foreach(UnicastIPAddressInformation unicast in unicastIPC) {
                                if(unicast.Address.AddressFamily == AddressFamily.InterNetwork) {
                                    cboxIPAddress.Items.Add(iface.Description + " @ " + unicast.Address);
                                }
                            }
                        }
                    }
                    cboxIPAddress.SelectedIndex = 0;
                    lblIPAdd.Text = "    Network Card IP:";
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

        private void AddAndForce() {
            if(cboxIPAddress.Text.Trim().Length <= 0) {
                MessageBox.Show(Messages.EMPTY_IP, "Empty IP Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtExeFile.Text.Trim().Length <= 0) {
                MessageBox.Show(Messages.EMPTY_EXE, "Empty Executable File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ipAddress = string.Empty;
            string[] ipChunks = cboxIPAddress.Text.Trim().Split('@');
            if(ipChunks.Length > 1) {
                ipAddress = ipChunks[1].Trim();
            } else {
                ipAddress = ipChunks[0].Trim();
            }
            if(cboxLocales.SelectedIndex == 2) {
                AddBind(cboxIPAddress.Text, ipAddress, txtExeFile.Text, chkAutoBind.Checked, chkEnableDelay.Checked);
            } else {
                if(Validator.CheckIPValid(ipAddress)) {
                    AddBind(cboxIPAddress.Text, ipAddress, txtExeFile.Text, chkAutoBind.Checked, chkEnableDelay.Checked);
                } else {
                    MessageBox.Show(string.Format(Messages.INVALID_IP, ipAddress), "Invalid IP Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddBind(string description, string ipAddress, string path, bool autoBind, bool delay) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                _bindings.Add(new Models.BindingIP() {
                    Description = description,
                    IPAddress = ipAddress,
                    Path = path,
                    AutoBind = autoBind ? 1 : 0
                });
                InitializeBindings();
                tabControlBind.SelectedIndex = 1;
            } catch {

            } finally {
                cboxLocales.SelectedIndex = 0;
                txtExeFile.Text = string.Empty;
                Cursor.Current = Cursors.Default;
            }
        }
        private void Action(string tag) {
            switch(tag) {
                case "ADD_FORCE":
                    if(tabControlBind.SelectedIndex != 0) {
                        tabControlBind.SelectedIndex = 0;
                    } else {

                        AddAndForce();
                    }
                    break;
                case "REMOVE":
                    if(listViewBind.SelectedItems.Count > 0 && !string.IsNullOrEmpty(_selectedId)) {
                        if(MessageBox.Show(string.Format(Messages.REMOVE, _selectedDesc), "Remove Bind Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes)) {
                            Cursor.Current = Cursors.WaitCursor;
                            if(_bindings != null) {
                                _bindings.Delete(_selectedId);
                                InitializeBindings();
                            }
                            Cursor.Current = Cursors.Default;
                        }
                    }
                    break;
                case "CLEAR":
                    if(MessageBox.Show(Messages.CLEAR, "Clear Bindings", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes)) {
                        Cursor.Current = Cursors.WaitCursor;
                        if(_bindings != null) {
                            _bindings.ClearAll();
                            InitializeBindings();
                        }
                        Cursor.Current = Cursors.Default;
                    }
                    break;
                case "AUTO_BIND":
                    if(listViewBind.SelectedItems.Count > 0 && !string.IsNullOrEmpty(_selectedAutoBind)) {
                        Cursor.Current = Cursors.WaitCursor;
                        if(_bindings != null) {
                            _bindings.SetAutoBind(_selectedId, _selectedAutoBind.Equals("Yes") ? false : true);
                            InitializeBindings();
                        }
                        Cursor.Current = Cursors.Default;
                    }
                    break;
                case "BROWSE":
                    using(OpenFileDialog ofd = new OpenFileDialog()) {
                        ofd.Filter = "Executable files (*.exe) |*.exe|All Files (*.*)|*.*";
                        if(ofd.ShowDialog().Equals(DialogResult.OK)) {
                            txtExeFile.Text = ofd.FileName;
                        }
                    }
                    break;
                case "OPTIONS":
                    using(OptionForm opt = new OptionForm()) {
                        opt.ShowDialog().Equals(DialogResult.OK);
                        InitializeOptions();
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
                    _cfgs.Set<bool>("Toolbar", menuToolbar.Checked);
                    toolStripBind.Visible = menuToolbar.Checked;
                    break;
                case "Statusbar":
                    _cfgs.Set<bool>("Statusbar", menuStatusbar.Checked);
                    statusStripBind.Visible = menuStatusbar.Checked;
                    break;
                case "Gridlines":
                    _cfgs.Set<bool>("Gridlines", menuGridlines.Checked);
                    listViewBind.GridLines = menuGridlines.Checked;
                    break;
                case "XPLook":
                    _cfgs.Set<bool>("XPLook", menuXPLook.Checked);
                    Application.Restart();
                    break;
                default:
                    break;
            }
        }
        private void IPBinderForm_Load(object sender, EventArgs e) {
            InitializeOptions();
            Login();
            InitializeForceBindIPFile();
            InitializeNetLocale();
            InitializeBindings();
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            if(e.CloseReason.Equals(CloseReason.UserClosing)) {
                if(MessageBox.Show(Messages.EXIT, "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.No)) {
                    e.Cancel = true;
                } else {
                    //@---TODO---
                }
            }
            base.OnFormClosing(e);
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

        private void timerCheck_Tick(object sender, EventArgs e) {
            btnAddForce.Enabled = (tabControlBind.SelectedIndex == 0 && cboxLocales.SelectedIndex >= 0 && cboxIPAddress.Text.Trim().Length > 0 && txtExeFile.Text.Trim().Length > 0);
            btnClear.Enabled = menuClear.Enabled = tabControlBind.SelectedIndex == 1;
            btnRemove.Enabled = menuRemove.Enabled = tabControlBind.SelectedIndex == 1 && listViewBind.SelectedItems.Count > 0;
        }

        private void listViewBind_SelectedIndexChanged(object sender, EventArgs e) {
            if(listViewBind.SelectedItems.Count > 0) {
                _selectedId = listViewBind.SelectedItems[0].SubItems[0].Text;
                _selectedDesc = listViewBind.SelectedItems[0].SubItems[1].Text;
                _selectedAutoBind = listViewBind.SelectedItems[0].SubItems[3].Text;
                btnAutoBindToggle.Visible = true;
                btnAutoBindToggle.Image = _selectedAutoBind.Equals("Yes") ? Resources.link_delete : Resources.link_go;
                btnAutoBindToggle.Text = _selectedAutoBind.Equals("Yes") ? "Disable auto bind during window startup" : "Set enable auto bind during window startup";
            } else {
                ClearSelection();
            }
        }

        private void tabControlBind_SelectedIndexChanged(object sender, EventArgs e) {
            //to make sure to clear selected item in list when leaving
            if(tabControlBind.SelectedIndex != 1) {
                ClearSelection();
            }
        }

        private void ClearSelection() {
            listViewBind.SelectedItems.Clear();
            _selectedId =
           _selectedDesc =
           _selectedAutoBind = string.Empty;
            btnAutoBindToggle.Visible = false;
        }
    }
}