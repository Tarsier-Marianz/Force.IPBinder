namespace Force.IPBinder {
    partial class IPBinderForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IPBinderForm));
            this.menuStripBind = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddForce = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuOpenCmd = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStatusbar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGridlines = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuXPLook = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuForceBindIP = new System.Windows.Forms.ToolStripMenuItem();
            this.installForceBindIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadForceBindIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBind = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnRemove = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.btnClearCmds = new System.Windows.Forms.ToolStripButton();
            this.btnAutoBindToggle = new System.Windows.Forms.ToolStripButton();
            this.btnPing = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnOptions = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.lblVersion = new System.Windows.Forms.ToolStripLabel();
            this.statusStripBind = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblIPAddress = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblForceBindIPFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblForceBindFind = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlBind = new System.Windows.Forms.TabControl();
            this.tabPageNewBind = new System.Windows.Forms.TabPage();
            this.btnAddForce = new System.Windows.Forms.Button();
            this.chkAutoBind = new System.Windows.Forms.CheckBox();
            this.chkEnableDelay = new System.Windows.Forms.CheckBox();
            this.cboxLocales = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxIPAddress = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtExeFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIPAdd = new System.Windows.Forms.Label();
            this.imgListBind = new System.Windows.Forms.ImageList();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageBindList = new System.Windows.Forms.TabPage();
            this.listViewBind = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAutoBind = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList16 = new System.Windows.Forms.ImageList();
            this.panelBindlist = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageCommand = new System.Windows.Forms.TabPage();
            this.btnSend = new Tarsier.UI.Buttons.SplitButton();
            this.menuContextSend = new System.Windows.Forms.ContextMenuStrip();
            this.predefinedCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ipconfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ipconfigallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ipconfigreleaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ipconfigrenewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arpaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxCommand = new System.Windows.Forms.ComboBox();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timerCheck = new System.Windows.Forms.Timer();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.menuStripBind.SuspendLayout();
            this.toolStripBind.SuspendLayout();
            this.statusStripBind.SuspendLayout();
            this.tabControlBind.SuspendLayout();
            this.tabPageNewBind.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPageBindList.SuspendLayout();
            this.panelBindlist.SuspendLayout();
            this.tabPageCommand.SuspendLayout();
            this.menuContextSend.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripBind
            // 
            this.menuStripBind.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripBind.Location = new System.Drawing.Point(0, 0);
            this.menuStripBind.Name = "menuStripBind";
            this.menuStripBind.Size = new System.Drawing.Size(579, 24);
            this.menuStripBind.TabIndex = 0;
            this.menuStripBind.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddForce,
            this.menuRemove,
            this.toolStripSeparator2,
            this.menuClear,
            this.toolStripSeparator3,
            this.menuExit});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.actionToolStripMenuItem.Text = "Bind";
            // 
            // menuAddForce
            // 
            this.menuAddForce.Image = ((System.Drawing.Image)(resources.GetObject("menuAddForce.Image")));
            this.menuAddForce.Name = "menuAddForce";
            this.menuAddForce.Size = new System.Drawing.Size(136, 22);
            this.menuAddForce.Tag = "ADD_FORCE";
            this.menuAddForce.Text = "Add && Bind";
            this.menuAddForce.Click += new System.EventHandler(this.Menus_Click);
            // 
            // menuRemove
            // 
            this.menuRemove.Image = ((System.Drawing.Image)(resources.GetObject("menuRemove.Image")));
            this.menuRemove.Name = "menuRemove";
            this.menuRemove.Size = new System.Drawing.Size(136, 22);
            this.menuRemove.Tag = "REMOVE";
            this.menuRemove.Text = "Remove";
            this.menuRemove.Click += new System.EventHandler(this.Menus_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(133, 6);
            // 
            // menuClear
            // 
            this.menuClear.Image = ((System.Drawing.Image)(resources.GetObject("menuClear.Image")));
            this.menuClear.Name = "menuClear";
            this.menuClear.Size = new System.Drawing.Size(136, 22);
            this.menuClear.Tag = "CLEAR";
            this.menuClear.Text = "Clear All";
            this.menuClear.Click += new System.EventHandler(this.Menus_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(133, 6);
            // 
            // menuExit
            // 
            this.menuExit.Image = ((System.Drawing.Image)(resources.GetObject("menuExit.Image")));
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(136, 22);
            this.menuExit.Tag = "EXIT";
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.Menus_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOptions,
            this.toolStripSeparator5,
            this.menuOpenCmd});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // menuOptions
            // 
            this.menuOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuOptions.Image")));
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Size = new System.Drawing.Size(206, 22);
            this.menuOptions.Tag = "OPTIONS";
            this.menuOptions.Text = "Options";
            this.menuOptions.Click += new System.EventHandler(this.Menus_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(203, 6);
            // 
            // menuOpenCmd
            // 
            this.menuOpenCmd.Image = ((System.Drawing.Image)(resources.GetObject("menuOpenCmd.Image")));
            this.menuOpenCmd.Name = "menuOpenCmd";
            this.menuOpenCmd.Size = new System.Drawing.Size(206, 22);
            this.menuOpenCmd.Tag = "CMD_PROMPT";
            this.menuOpenCmd.Text = "Open Command Prompt";
            this.menuOpenCmd.Click += new System.EventHandler(this.Menus_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolbar,
            this.menuStatusbar,
            this.menuGridlines,
            this.toolStripSeparator4,
            this.menuXPLook});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // menuToolbar
            // 
            this.menuToolbar.CheckOnClick = true;
            this.menuToolbar.Name = "menuToolbar";
            this.menuToolbar.Size = new System.Drawing.Size(123, 22);
            this.menuToolbar.Tag = "Toolbar";
            this.menuToolbar.Text = "Toolbar";
            this.menuToolbar.Click += new System.EventHandler(this.Menus_Click);
            // 
            // menuStatusbar
            // 
            this.menuStatusbar.CheckOnClick = true;
            this.menuStatusbar.Name = "menuStatusbar";
            this.menuStatusbar.Size = new System.Drawing.Size(123, 22);
            this.menuStatusbar.Tag = "Statusbar";
            this.menuStatusbar.Text = "Statusbar";
            this.menuStatusbar.Click += new System.EventHandler(this.Menus_Click);
            // 
            // menuGridlines
            // 
            this.menuGridlines.CheckOnClick = true;
            this.menuGridlines.Name = "menuGridlines";
            this.menuGridlines.Size = new System.Drawing.Size(123, 22);
            this.menuGridlines.Tag = "Gridlines";
            this.menuGridlines.Text = "Gridlines";
            this.menuGridlines.Click += new System.EventHandler(this.Menus_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(120, 6);
            // 
            // menuXPLook
            // 
            this.menuXPLook.CheckOnClick = true;
            this.menuXPLook.Name = "menuXPLook";
            this.menuXPLook.Size = new System.Drawing.Size(123, 22);
            this.menuXPLook.Tag = "XPLook";
            this.menuXPLook.Text = "XP Look";
            this.menuXPLook.Click += new System.EventHandler(this.Menus_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuForceBindIP,
            this.installForceBindIPToolStripMenuItem,
            this.downloadForceBindIPToolStripMenuItem,
            this.toolStripSeparator1,
            this.menuHelp,
            this.menuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuForceBindIP
            // 
            this.menuForceBindIP.Image = ((System.Drawing.Image)(resources.GetObject("menuForceBindIP.Image")));
            this.menuForceBindIP.Name = "menuForceBindIP";
            this.menuForceBindIP.Size = new System.Drawing.Size(194, 22);
            this.menuForceBindIP.Tag = "FORCEBIND_SITE";
            this.menuForceBindIP.Text = "ForceBindIP Website";
            this.menuForceBindIP.Click += new System.EventHandler(this.Menus_Click);
            // 
            // installForceBindIPToolStripMenuItem
            // 
            this.installForceBindIPToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("installForceBindIPToolStripMenuItem.Image")));
            this.installForceBindIPToolStripMenuItem.Name = "installForceBindIPToolStripMenuItem";
            this.installForceBindIPToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.installForceBindIPToolStripMenuItem.Tag = "FORCEBIND_INSTALL";
            this.installForceBindIPToolStripMenuItem.Text = "Install ForceBindIP";
            this.installForceBindIPToolStripMenuItem.Click += new System.EventHandler(this.Menus_Click);
            // 
            // downloadForceBindIPToolStripMenuItem
            // 
            this.downloadForceBindIPToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("downloadForceBindIPToolStripMenuItem.Image")));
            this.downloadForceBindIPToolStripMenuItem.Name = "downloadForceBindIPToolStripMenuItem";
            this.downloadForceBindIPToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.downloadForceBindIPToolStripMenuItem.Tag = "FORCEBIND_DOWN";
            this.downloadForceBindIPToolStripMenuItem.Text = "Download ForceBindIP";
            this.downloadForceBindIPToolStripMenuItem.Click += new System.EventHandler(this.Menus_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // menuHelp
            // 
            this.menuHelp.Image = ((System.Drawing.Image)(resources.GetObject("menuHelp.Image")));
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(194, 22);
            this.menuHelp.Tag = "HELP";
            this.menuHelp.Text = "Documentation";
            this.menuHelp.Click += new System.EventHandler(this.Menus_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Image = ((System.Drawing.Image)(resources.GetObject("menuAbout.Image")));
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(194, 22);
            this.menuAbout.Tag = "ABOUT";
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.Menus_Click);
            // 
            // toolStripBind
            // 
            this.toolStripBind.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnRemove,
            this.btnClear,
            this.btnClearCmds,
            this.btnAutoBindToggle,
            this.btnPing,
            this.toolStripLabel1,
            this.btnOptions,
            this.btnHelp,
            this.btnExit,
            this.lblVersion});
            this.toolStripBind.Location = new System.Drawing.Point(0, 24);
            this.toolStripBind.Name = "toolStripBind";
            this.toolStripBind.Size = new System.Drawing.Size(579, 25);
            this.toolStripBind.TabIndex = 1;
            this.toolStripBind.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Tag = "ADD_FORCE";
            this.btnAdd.Text = "Add and force bind IP address";
            this.btnAdd.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(23, 22);
            this.btnRemove.Tag = "REMOVE";
            this.btnRemove.Text = "Remove selected bind application in list";
            this.btnRemove.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(23, 22);
            this.btnClear.Tag = "CLEAR";
            this.btnClear.Text = "Clear all binded application in list";
            this.btnClear.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnClearCmds
            // 
            this.btnClearCmds.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClearCmds.Enabled = false;
            this.btnClearCmds.Image = ((System.Drawing.Image)(resources.GetObject("btnClearCmds.Image")));
            this.btnClearCmds.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearCmds.Name = "btnClearCmds";
            this.btnClearCmds.Size = new System.Drawing.Size(23, 22);
            this.btnClearCmds.Tag = "CLEAR_CMDS";
            this.btnClearCmds.Text = "Clear command line contents";
            this.btnClearCmds.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnAutoBindToggle
            // 
            this.btnAutoBindToggle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAutoBindToggle.Image = global::Force.IPBinder.Properties.Resources.link_delete;
            this.btnAutoBindToggle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAutoBindToggle.Name = "btnAutoBindToggle";
            this.btnAutoBindToggle.Size = new System.Drawing.Size(23, 22);
            this.btnAutoBindToggle.Tag = "AUTO_BIND";
            this.btnAutoBindToggle.Visible = false;
            this.btnAutoBindToggle.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnPing
            // 
            this.btnPing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPing.Image = global::Force.IPBinder.Properties.Resources.ping_start;
            this.btnPing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(23, 22);
            this.btnPing.Tag = "PING_START";
            this.btnPing.Text = "Ping selected ";
            this.btnPing.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel1.Text = "   ";
            // 
            // btnOptions
            // 
            this.btnOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOptions.Image")));
            this.btnOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(23, 22);
            this.btnOptions.Tag = "OPTIONS";
            this.btnOptions.Text = "System options";
            this.btnOptions.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 22);
            this.btnHelp.Tag = "HELP";
            this.btnHelp.Text = "Documentation";
            this.btnHelp.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 22);
            this.btnExit.Tag = "EXIT";
            this.btnExit.Text = "Exit application";
            this.btnExit.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(13, 22);
            this.lblVersion.Text = "v";
            // 
            // statusStripBind
            // 
            this.statusStripBind.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblIPAddress,
            this.toolStripStatusLabel2,
            this.lblForceBindIPFile,
            this.lblForceBindFind});
            this.statusStripBind.Location = new System.Drawing.Point(0, 304);
            this.statusStripBind.Name = "statusStripBind";
            this.statusStripBind.Size = new System.Drawing.Size(579, 22);
            this.statusStripBind.TabIndex = 2;
            this.statusStripBind.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.Text = "Ready...";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(10, 17);
            this.lblIPAddress.Text = ".";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabel2.Text = "        ";
            // 
            // lblForceBindIPFile
            // 
            this.lblForceBindIPFile.Name = "lblForceBindIPFile";
            this.lblForceBindIPFile.Size = new System.Drawing.Size(73, 17);
            this.lblForceBindIPFile.Text = "ForceBindIP:";
            // 
            // lblForceBindFind
            // 
            this.lblForceBindFind.ForeColor = System.Drawing.Color.Red;
            this.lblForceBindFind.Name = "lblForceBindFind";
            this.lblForceBindFind.Size = new System.Drawing.Size(64, 17);
            this.lblForceBindFind.Text = "Not Found";
            // 
            // tabControlBind
            // 
            this.tabControlBind.Controls.Add(this.tabPageNewBind);
            this.tabControlBind.Controls.Add(this.tabPageBindList);
            this.tabControlBind.Controls.Add(this.tabPageCommand);
            this.tabControlBind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlBind.ImageList = this.imgListBind;
            this.tabControlBind.Location = new System.Drawing.Point(0, 49);
            this.tabControlBind.Name = "tabControlBind";
            this.tabControlBind.SelectedIndex = 0;
            this.tabControlBind.Size = new System.Drawing.Size(579, 255);
            this.tabControlBind.TabIndex = 3;
            this.tabControlBind.SelectedIndexChanged += new System.EventHandler(this.tabControlBind_SelectedIndexChanged);
            // 
            // tabPageNewBind
            // 
            this.tabPageNewBind.Controls.Add(this.btnAddForce);
            this.tabPageNewBind.Controls.Add(this.chkAutoBind);
            this.tabPageNewBind.Controls.Add(this.chkEnableDelay);
            this.tabPageNewBind.Controls.Add(this.cboxLocales);
            this.tabPageNewBind.Controls.Add(this.label6);
            this.tabPageNewBind.Controls.Add(this.cboxIPAddress);
            this.tabPageNewBind.Controls.Add(this.btnBrowse);
            this.tabPageNewBind.Controls.Add(this.txtExeFile);
            this.tabPageNewBind.Controls.Add(this.label5);
            this.tabPageNewBind.Controls.Add(this.lblIPAdd);
            this.tabPageNewBind.Controls.Add(this.panel2);
            this.tabPageNewBind.ImageIndex = 0;
            this.tabPageNewBind.Location = new System.Drawing.Point(4, 23);
            this.tabPageNewBind.Name = "tabPageNewBind";
            this.tabPageNewBind.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewBind.Size = new System.Drawing.Size(571, 228);
            this.tabPageNewBind.TabIndex = 0;
            this.tabPageNewBind.Text = "New Bind";
            this.tabPageNewBind.UseVisualStyleBackColor = true;
            // 
            // btnAddForce
            // 
            this.btnAddForce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddForce.Image = ((System.Drawing.Image)(resources.GetObject("btnAddForce.Image")));
            this.btnAddForce.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddForce.Location = new System.Drawing.Point(439, 152);
            this.btnAddForce.Name = "btnAddForce";
            this.btnAddForce.Size = new System.Drawing.Size(105, 45);
            this.btnAddForce.TabIndex = 12;
            this.btnAddForce.Tag = "ADD_FORCE";
            this.btnAddForce.Text = "Add && Force Bind";
            this.btnAddForce.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddForce.UseVisualStyleBackColor = true;
            this.btnAddForce.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // chkAutoBind
            // 
            this.chkAutoBind.AutoSize = true;
            this.chkAutoBind.Location = new System.Drawing.Point(142, 180);
            this.chkAutoBind.Name = "chkAutoBind";
            this.chkAutoBind.Size = new System.Drawing.Size(182, 17);
            this.chkAutoBind.TabIndex = 11;
            this.chkAutoBind.Tag = "AutoBind";
            this.chkAutoBind.Text = "Auro bind during window startup";
            this.chkAutoBind.UseVisualStyleBackColor = true;
            // 
            // chkEnableDelay
            // 
            this.chkEnableDelay.AutoSize = true;
            this.chkEnableDelay.Location = new System.Drawing.Point(142, 152);
            this.chkEnableDelay.Name = "chkEnableDelay";
            this.chkEnableDelay.Size = new System.Drawing.Size(200, 17);
            this.chkEnableDelay.TabIndex = 10;
            this.chkEnableDelay.Tag = "EnableDelay";
            this.chkEnableDelay.Text = "Enable delay injection (-i) parameter";
            this.chkEnableDelay.UseVisualStyleBackColor = true;
            // 
            // cboxLocales
            // 
            this.cboxLocales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxLocales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxLocales.FormattingEnabled = true;
            this.cboxLocales.Location = new System.Drawing.Point(142, 39);
            this.cboxLocales.Name = "cboxLocales";
            this.cboxLocales.Size = new System.Drawing.Size(364, 21);
            this.cboxLocales.TabIndex = 9;
            this.cboxLocales.SelectedIndexChanged += new System.EventHandler(this.cboxLocales_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(14, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "       IP Locale:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboxIPAddress
            // 
            this.cboxIPAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxIPAddress.FormattingEnabled = true;
            this.cboxIPAddress.Location = new System.Drawing.Point(142, 71);
            this.cboxIPAddress.Name = "cboxIPAddress";
            this.cboxIPAddress.Size = new System.Drawing.Size(364, 21);
            this.cboxIPAddress.TabIndex = 7;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowse.Location = new System.Drawing.Point(513, 105);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(31, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Tag = "BROWSE";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // txtExeFile
            // 
            this.txtExeFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExeFile.BackColor = System.Drawing.Color.White;
            this.txtExeFile.Location = new System.Drawing.Point(142, 106);
            this.txtExeFile.Name = "txtExeFile";
            this.txtExeFile.ReadOnly = true;
            this.txtExeFile.Size = new System.Drawing.Size(364, 21);
            this.txtExeFile.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(14, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "       Application Path:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIPAdd
            // 
            this.lblIPAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIPAdd.ImageIndex = 5;
            this.lblIPAdd.ImageList = this.imgListBind;
            this.lblIPAdd.Location = new System.Drawing.Point(14, 69);
            this.lblIPAdd.Name = "lblIPAdd";
            this.lblIPAdd.Size = new System.Drawing.Size(127, 23);
            this.lblIPAdd.TabIndex = 3;
            this.lblIPAdd.Text = "       Network Card GUID:";
            this.lblIPAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgListBind
            // 
            this.imgListBind.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListBind.ImageStream")));
            this.imgListBind.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListBind.Images.SetKeyName(0, "link.png");
            this.imgListBind.Images.SetKeyName(1, "computer_link.png");
            this.imgListBind.Images.SetKeyName(2, "application_xp_terminal.png");
            this.imgListBind.Images.SetKeyName(3, "network_adapter.png");
            this.imgListBind.Images.SetKeyName(4, "network_ethernet.png");
            this.imgListBind.Images.SetKeyName(5, "network_hub.png");
            this.imgListBind.Images.SetKeyName(6, "network_ip.png");
            this.imgListBind.Images.SetKeyName(7, "network_tools.png");
            this.imgListBind.Images.SetKeyName(8, "network_wireless.png");
            this.imgListBind.Images.SetKeyName(9, "servers_network.png");
            this.imgListBind.Images.SetKeyName(10, "link_go.png");
            this.imgListBind.Images.SetKeyName(11, "link_add.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 30);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(11, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Please select/enter ip address or enter GUID of netwok interface adapter.";
            // 
            // tabPageBindList
            // 
            this.tabPageBindList.Controls.Add(this.listViewBind);
            this.tabPageBindList.Controls.Add(this.panelBindlist);
            this.tabPageBindList.ImageIndex = 1;
            this.tabPageBindList.Location = new System.Drawing.Point(4, 23);
            this.tabPageBindList.Name = "tabPageBindList";
            this.tabPageBindList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBindList.Size = new System.Drawing.Size(571, 228);
            this.tabPageBindList.TabIndex = 1;
            this.tabPageBindList.Text = "Bind List";
            this.tabPageBindList.UseVisualStyleBackColor = true;
            // 
            // listViewBind
            // 
            this.listViewBind.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderDesc,
            this.columnHeaderPath,
            this.columnHeaderAutoBind});
            this.listViewBind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewBind.FullRowSelect = true;
            this.listViewBind.GridLines = true;
            this.listViewBind.Location = new System.Drawing.Point(3, 33);
            this.listViewBind.MultiSelect = false;
            this.listViewBind.Name = "listViewBind";
            this.listViewBind.Size = new System.Drawing.Size(565, 192);
            this.listViewBind.SmallImageList = this.imageList16;
            this.listViewBind.TabIndex = 2;
            this.listViewBind.UseCompatibleStateImageBehavior = false;
            this.listViewBind.View = System.Windows.Forms.View.Details;
            this.listViewBind.SelectedIndexChanged += new System.EventHandler(this.listViewBind_SelectedIndexChanged);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "#";
            this.columnHeaderID.Width = 41;
            // 
            // columnHeaderDesc
            // 
            this.columnHeaderDesc.Text = "Description";
            this.columnHeaderDesc.Width = 186;
            // 
            // columnHeaderPath
            // 
            this.columnHeaderPath.Text = "Application Path";
            this.columnHeaderPath.Width = 263;
            // 
            // columnHeaderAutoBind
            // 
            this.columnHeaderAutoBind.Text = "Auto Bind";
            // 
            // imageList16
            // 
            this.imageList16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList16.ImageStream")));
            this.imageList16.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList16.Images.SetKeyName(0, "tick-circle.png");
            // 
            // panelBindlist
            // 
            this.panelBindlist.Controls.Add(this.label2);
            this.panelBindlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBindlist.Location = new System.Drawing.Point(3, 3);
            this.panelBindlist.Name = "panelBindlist";
            this.panelBindlist.Size = new System.Drawing.Size(565, 30);
            this.panelBindlist.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(11, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "List of application being binded to specific IP address or GUID of network interf" +
    "ace adapter.";
            // 
            // tabPageCommand
            // 
            this.tabPageCommand.Controls.Add(this.btnSend);
            this.tabPageCommand.Controls.Add(this.label4);
            this.tabPageCommand.Controls.Add(this.cboxCommand);
            this.tabPageCommand.Controls.Add(this.listBoxLog);
            this.tabPageCommand.Controls.Add(this.panel1);
            this.tabPageCommand.ImageIndex = 2;
            this.tabPageCommand.Location = new System.Drawing.Point(4, 23);
            this.tabPageCommand.Name = "tabPageCommand";
            this.tabPageCommand.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCommand.Size = new System.Drawing.Size(571, 228);
            this.tabPageCommand.TabIndex = 2;
            this.tabPageCommand.Text = "Commands";
            this.tabPageCommand.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.AutoSize = true;
            this.btnSend.ContextMenuStrip = this.menuContextSend;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.Location = new System.Drawing.Point(490, 38);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(76, 23);
            this.btnSend.SplitMenuStrip = this.menuContextSend;
            this.btnSend.TabIndex = 1;
            this.btnSend.Tag = "SEND";
            this.btnSend.Text = "Send";
            this.btnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // menuContextSend
            // 
            this.menuContextSend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.predefinedCommandsToolStripMenuItem,
            this.ipconfigToolStripMenuItem,
            this.ipconfigallToolStripMenuItem,
            this.ipconfigreleaseToolStripMenuItem,
            this.ipconfigrenewToolStripMenuItem,
            this.arpaToolStripMenuItem});
            this.menuContextSend.Name = "menuContextSend";
            this.menuContextSend.Size = new System.Drawing.Size(201, 136);
            // 
            // predefinedCommandsToolStripMenuItem
            // 
            this.predefinedCommandsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predefinedCommandsToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.predefinedCommandsToolStripMenuItem.Name = "predefinedCommandsToolStripMenuItem";
            this.predefinedCommandsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.predefinedCommandsToolStripMenuItem.Text = "Predefined Commands";
            // 
            // ipconfigToolStripMenuItem
            // 
            this.ipconfigToolStripMenuItem.Name = "ipconfigToolStripMenuItem";
            this.ipconfigToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ipconfigToolStripMenuItem.Tag = "ipconfig";
            this.ipconfigToolStripMenuItem.Text = "ipconfig";
            this.ipconfigToolStripMenuItem.Click += new System.EventHandler(this.Menus_Click);
            // 
            // ipconfigallToolStripMenuItem
            // 
            this.ipconfigallToolStripMenuItem.Name = "ipconfigallToolStripMenuItem";
            this.ipconfigallToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ipconfigallToolStripMenuItem.Tag = "ipconfig /all";
            this.ipconfigallToolStripMenuItem.Text = "ipconfig /all";
            this.ipconfigallToolStripMenuItem.Click += new System.EventHandler(this.Menus_Click);
            // 
            // ipconfigreleaseToolStripMenuItem
            // 
            this.ipconfigreleaseToolStripMenuItem.Name = "ipconfigreleaseToolStripMenuItem";
            this.ipconfigreleaseToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ipconfigreleaseToolStripMenuItem.Tag = "ipconfig /release";
            this.ipconfigreleaseToolStripMenuItem.Text = "ipconfig /release";
            this.ipconfigreleaseToolStripMenuItem.Click += new System.EventHandler(this.Menus_Click);
            // 
            // ipconfigrenewToolStripMenuItem
            // 
            this.ipconfigrenewToolStripMenuItem.Name = "ipconfigrenewToolStripMenuItem";
            this.ipconfigrenewToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ipconfigrenewToolStripMenuItem.Tag = "ipconfig /renew";
            this.ipconfigrenewToolStripMenuItem.Text = "ipconfig /renew";
            this.ipconfigrenewToolStripMenuItem.Click += new System.EventHandler(this.Menus_Click);
            // 
            // arpaToolStripMenuItem
            // 
            this.arpaToolStripMenuItem.Name = "arpaToolStripMenuItem";
            this.arpaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.arpaToolStripMenuItem.Tag = "arp -a";
            this.arpaToolStripMenuItem.Text = "arp -a";
            this.arpaToolStripMenuItem.Click += new System.EventHandler(this.Menus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Command:";
            // 
            // cboxCommand
            // 
            this.cboxCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxCommand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxCommand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboxCommand.FormattingEnabled = true;
            this.cboxCommand.Location = new System.Drawing.Point(72, 39);
            this.cboxCommand.Name = "cboxCommand";
            this.cboxCommand.Size = new System.Drawing.Size(412, 21);
            this.cboxCommand.TabIndex = 5;
            this.cboxCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxCommand_KeyDown);
            // 
            // listBoxLog
            // 
            this.listBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLog.BackColor = System.Drawing.Color.Black;
            this.listBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxLog.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBoxLog.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLog.ForeColor = System.Drawing.Color.White;
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 15;
            this.listBoxLog.Location = new System.Drawing.Point(3, 64);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(562, 152);
            this.listBoxLog.TabIndex = 4;
            this.listBoxLog.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxLog_DrawItem);
            this.listBoxLog.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.listBoxLog_MeasureItem);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 30);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your command or select predefined basic IP configuration commands executed " +
    "on command prompt.";
            // 
            // timerCheck
            // 
            this.timerCheck.Enabled = true;
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // IPBinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 326);
            this.Controls.Add(this.tabControlBind);
            this.Controls.Add(this.statusStripBind);
            this.Controls.Add(this.toolStripBind);
            this.Controls.Add(this.menuStripBind);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripBind;
            this.Name = "IPBinderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Force IP-Binder/ Tarsier GUI";
            this.Load += new System.EventHandler(this.IPBinderForm_Load);
            this.menuStripBind.ResumeLayout(false);
            this.menuStripBind.PerformLayout();
            this.toolStripBind.ResumeLayout(false);
            this.toolStripBind.PerformLayout();
            this.statusStripBind.ResumeLayout(false);
            this.statusStripBind.PerformLayout();
            this.tabControlBind.ResumeLayout(false);
            this.tabPageNewBind.ResumeLayout(false);
            this.tabPageNewBind.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPageBindList.ResumeLayout(false);
            this.panelBindlist.ResumeLayout(false);
            this.panelBindlist.PerformLayout();
            this.tabPageCommand.ResumeLayout(false);
            this.tabPageCommand.PerformLayout();
            this.menuContextSend.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripBind;
        private System.Windows.Forms.ToolStrip toolStripBind;
        private System.Windows.Forms.StatusStrip statusStripBind;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolbar;
        private System.Windows.Forms.ToolStripMenuItem menuStatusbar;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnRemove;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.TabControl tabControlBind;
        private System.Windows.Forms.TabPage tabPageNewBind;
        private System.Windows.Forms.TabPage tabPageBindList;
        private System.Windows.Forms.Panel panelBindlist;
        private System.Windows.Forms.TabPage tabPageCommand;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxIPAddress;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtExeFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIPAdd;
        private System.Windows.Forms.ComboBox cboxLocales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkAutoBind;
        private System.Windows.Forms.CheckBox chkEnableDelay;
        private System.Windows.Forms.ToolStripButton btnOptions;
        private System.Windows.Forms.Button btnAddForce;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddForce;
        private System.Windows.Forms.ToolStripMenuItem menuRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuClear;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ImageList imgListBind;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuForceBindIP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOptions;
        private System.Windows.Forms.ListView listViewBind;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderDesc;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.ColumnHeader columnHeaderAutoBind;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuGridlines;
        private System.Windows.Forms.ToolStripMenuItem menuXPLook;
        private System.Windows.Forms.Timer timerCheck;
        private System.Windows.Forms.ToolStripStatusLabel lblForceBindIPFile;
        private System.Windows.Forms.ToolStripStatusLabel lblForceBindFind;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripButton btnAutoBindToggle;
        private System.Windows.Forms.ImageList imageList16;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxCommand;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menuOpenCmd;
        private Tarsier.UI.Buttons.SplitButton btnSend;
        private System.Windows.Forms.ContextMenuStrip menuContextSend;
        private System.Windows.Forms.ToolStripMenuItem predefinedCommandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ipconfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ipconfigallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ipconfigreleaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ipconfigrenewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arpaToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel lblVersion;
        private System.Windows.Forms.ToolStripMenuItem downloadForceBindIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installForceBindIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblIPAddress;
        private System.Windows.Forms.ToolStripButton btnPing;
        private System.Windows.Forms.ToolStripButton btnClearCmds;
    }
}

