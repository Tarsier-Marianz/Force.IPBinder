using Force.IPBinder.Constants;
using Force.IPBinder.Controllers;
using Force.IPBinder.Enums;
using Force.IPBinder.Forms;
using Force.IPBinder.Helpers;
using Force.IPBinder.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Tarsier.Extensions;
using Tarsier.Networks;
using Tarsier.Security;
using Tarsier.UI.Buttons;
using Tarsier.UI.Icons;

namespace Force.IPBinder {
    public partial class IPBinderForm : Form {
        private Configs _cfgs = new Configs(BindingFile.DatabaseFile);
        private Bindings _bindings = new Bindings(BindingFile.DatabaseFile);
        private Commands _cmds = new Commands(BindingFile.DatabaseFile);
        private NetworksAdapterInfo _networkInfo;
        private IconListManager _iconListManager;
        private bool _operationalStatusOnly = false;
        private bool _setPassword = false;
        private bool _isSendingCmd = false;
        private string _delayInject = string.Empty;
        private string _password = string.Empty;
        private string _selectedId = string.Empty;
        private string _selectedDesc = string.Empty;
        private string _selectedAutoBind = string.Empty;
        public IPBinderForm() {
            InitializeComponent();
        }
        private void InitializeOptions() {
            _iconListManager = new IconListManager(imageList16, IconReader.IconSize.Small);

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
            _iconListManager.ClearLists(); // to refresh Icon from .exe
            listViewBind.Items.Clear();
            _bindings = new Bindings(BindingFile.DatabaseFile);
            _bindings.Initialize(listViewBind, _iconListManager);
            ClearSelection();
        }

        private void InitializeCommands() {
            cboxCommand.Items.Clear();
            cboxCommand.AutoCompleteCustomSource = _cmds.GetAutoCompleteSource();
            //cboxCommand.DataSource = _cmds.GetAutoCompleteSource();
        }
        private void InitializeForceBindIPFile() {
            string ForceBindIPx86 = Path.Combine(Application.StartupPath, "ForceBindIP", "ForceBindIP64.exe");
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

            string forceBindExe = Path.Combine(Application.StartupPath, "ForceBindIP", "ForceBindIP64.exe");
            if(!bgWorker.IsBusy) {
                btnSend.Enabled = cboxCommand.Enabled = false;
                bgWorker.RunWorkerAsync(new CLIParameters() {
                    Filename = "CMD",
                    Prefix = "/k",
                    Arguments = string.Format("\"{0}\" {1} \"{2}\"", forceBindExe, ipAddress, path),
                });

                _bindings.Add(new Models.BindingIP() {
                    Description = description,
                    IPAddress = ipAddress,
                    Path = path,
                    AutoBind = autoBind ? 1 : 0
                });
            }

            InitializeBindings();
            tabControlBind.SelectedIndex = 1;

            cboxLocales.SelectedIndex = 0;
            txtExeFile.Text = string.Empty;
            Cursor.Current = Cursors.Default;
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
                case "CMD_PROMPT":
                    new Process {
                        StartInfo ={
                            UseShellExecute = true,
                            FileName = "cmd",
                            Arguments = ""
                        }
                    }.Start();
                    break;
                case "SEND":
                    if(cboxCommand.Text.Trim().Length > 0) {
                        if(!bgWorker.IsBusy) {
                            btnSend.Enabled = cboxCommand.Enabled = false;
                            bgWorker.RunWorkerAsync(new CLIParameters() {
                                Filename = "CMD",
                                Prefix = "/c ",
                                Arguments = cboxCommand.Text.Trim()
                            });
                        }
                    }else {
                        AppendResult("Please enter command...");
                    }
                    break;
                case "ipconfig":
                    SendPredefinedCommand(tag);
                    break;
                case "ipconfig /all":
                    SendPredefinedCommand(tag);
                    break;
                case "ipconfig /release":
                    SendPredefinedCommand(tag);
                    break;
                case "ipconfig /renew":
                    SendPredefinedCommand(tag);
                    break;
                case "arp -a":
                    SendPredefinedCommand(tag);
                    break;
                default:
                    break;
            }
        }

        private void SendPredefinedCommand(string command) {
            if(!bgWorker.IsBusy) {
                bgWorker.RunWorkerAsync(new CLIParameters() {
                    Filename = "CMD",
                    Prefix = "/k ",
                    Arguments = command
                });
            }
        }
        private void IPBinderForm_Load(object sender, EventArgs e) {
            InitializeOptions();
            Login();
            InitializeForceBindIPFile();
            InitializeNetLocale();
            InitializeBindings();
            InitializeCommands();
            if(!bgWorker.IsBusy) {
                btnSend.Enabled = cboxCommand.Enabled = false;
                bgWorker.RunWorkerAsync(new CLIParameters() {
                    Filename = "CMD",
                    Prefix= "/c",
                    Arguments = string.Empty
                });
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            if(e.CloseReason.Equals(CloseReason.UserClosing)) {
                if(MessageBox.Show(Messages.EXIT, "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.No)) {
                    e.Cancel = true;
                } else {
                    //@---TODO---
                    if(bgWorker.IsBusy) {
                        bgWorker.CancelAsync();
                        bgWorker.DoWork -= bgWorker_DoWork;
                        bgWorker.RunWorkerCompleted -= bgWorker_RunWorkerCompleted;
                    }
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
                } else {
                    SplitButton sbtn = sender as SplitButton;
                    if(btn != null) {
                        if(btn.Tag != null) {
                            Action(btn.Tag.ToString());
                        }
                    }
                }
            }
        }

        private void timerCheck_Tick(object sender, EventArgs e) {
            btnAddForce.Enabled = (tabControlBind.SelectedIndex == 0 && cboxLocales.SelectedIndex >= 0 && cboxIPAddress.Text.Trim().Length > 0 && txtExeFile.Text.Trim().Length > 0);
            btnClear.Enabled = menuClear.Enabled = tabControlBind.SelectedIndex == 1;
            btnRemove.Enabled = menuRemove.Enabled = tabControlBind.SelectedIndex == 1 && listViewBind.SelectedItems.Count > 0;
            //btnSend.Enabled = !_isSendingCmd && cboxCommand.Text.Trim().Length > 0;
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

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e) {
            var process = new Process();
            _isSendingCmd = true;
            CLIParameters cli = (CLIParameters)e.Argument;
            string arguments = cli.Arguments;
            string prefix = cli.Prefix.Trim();
            process.StartInfo.FileName = cli.Filename;
            if(!string.IsNullOrEmpty(arguments)) {
                process.StartInfo.Arguments = prefix + " " + arguments;
            }

            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;

            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            var stdOutput = new StringBuilder();
            process.OutputDataReceived += Process_OutputDataReceived;
            string stdError = null;

            process.Start();
            process.BeginOutputReadLine();
            stdError = process.StandardError.ReadToEnd();
            process.WaitForExit();
            //AppendResult("File: " + cli.Filename);
            //AppendResult("Args: " + cli.Arguments);

            if(process.ExitCode == 0) {
                AppendResult(stdOutput.ToSafeString());
            } else {
                //AppendResult(" finished with exit code = " + process.ExitCode);
                AppendResult(string.Format("'{0}' is not recognized as an internal or external command, operable program or batch file.", arguments));
            }
            _cmds.Add(arguments);
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e) {
            AppendResult(e.Data);
            Thread.Sleep(10);
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            cboxCommand.Text = string.Empty;
            AppendResult(Environment.NewLine);
            AppendResult("***************************************************************");
            AppendResult(Environment.NewLine);
            InitializeCommands();
            btnSend.Enabled = cboxCommand.Enabled = true;
            _isSendingCmd = false;
            cboxCommand.Focus();
        }

        private void AppendResult(string message) {
            if(string.IsNullOrEmpty(message)) return;

            if(listBoxLog.InvokeRequired) {
                listBoxLog.Invoke((MethodInvoker)delegate () {
                    listBoxLog.Items.Add(message);
                    listBoxLog.SelectedIndex = listBoxLog.Items.Count - 1;
                });
            } else {
                listBoxLog.Items.Add(message);
                listBoxLog.SelectedIndex = listBoxLog.Items.Count - 1;
            }
        }

        private void cboxCommand_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode.Equals(Keys.Enter)) {
                if(btnSend.Enabled) {
                    btnSend.PerformClick();
                }
            }
        }

        private void listBoxLog_DrawItem(object sender, DrawItemEventArgs e) {
            ListBox lb = (ListBox)sender;
            //e.DrawBackground();
            string item = lb.Items[e.Index].ToString();
            Graphics g = e.Graphics;
            e.DrawBackground();
            Brush lineBrush = Brushes.White;
            if(item.Contains("is not recognized")) {
                lineBrush = new SolidBrush(Color.Red);
            } else if(item.Contains("Please enter")) {
                lineBrush = new SolidBrush(Color.Orange);
            }
            g.DrawString(item, e.Font, lineBrush, new PointF(e.Bounds.X, e.Bounds.Y));
            e.DrawFocusRectangle();
        }

    }
}