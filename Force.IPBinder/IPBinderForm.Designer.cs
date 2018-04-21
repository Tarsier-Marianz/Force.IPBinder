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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IPBinderForm));
            this.menuStripBind = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStatusbar = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBind = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnRemove = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.statusStripBind = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlBind = new System.Windows.Forms.TabControl();
            this.tabPageNewBind = new System.Windows.Forms.TabPage();
            this.cboxLocales = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxIPAddress = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtExeFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIPAdd = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageBindList = new System.Windows.Forms.TabPage();
            this.listViewBind = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAutoBind = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelBindlist = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageCommand = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIPConfigRenew = new System.Windows.Forms.Button();
            this.btnIPConfigRelease = new System.Windows.Forms.Button();
            this.btnIPConfig = new System.Windows.Forms.Button();
            this.chkEnableDelay = new System.Windows.Forms.CheckBox();
            this.chkAutoBind = new System.Windows.Forms.CheckBox();
            this.btnOptions = new System.Windows.Forms.ToolStripButton();
            this.btnAddForce = new System.Windows.Forms.Button();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddForce = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.imgListBind = new System.Windows.Forms.ImageList(this.components);
            this.menuForceBindIP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeaderDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStripBind.SuspendLayout();
            this.toolStripBind.SuspendLayout();
            this.statusStripBind.SuspendLayout();
            this.tabControlBind.SuspendLayout();
            this.tabPageNewBind.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPageBindList.SuspendLayout();
            this.panelBindlist.SuspendLayout();
            this.tabPageCommand.SuspendLayout();
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
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolbar,
            this.menuStatusbar});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // menuToolbar
            // 
            this.menuToolbar.Name = "menuToolbar";
            this.menuToolbar.Size = new System.Drawing.Size(152, 22);
            this.menuToolbar.Tag = "Toolbar";
            this.menuToolbar.Text = "Toolbar";
            // 
            // menuStatusbar
            // 
            this.menuStatusbar.Name = "menuStatusbar";
            this.menuStatusbar.Size = new System.Drawing.Size(152, 22);
            this.menuStatusbar.Tag = "Statusbar";
            this.menuStatusbar.Text = "Statusbar";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuForceBindIP,
            this.toolStripSeparator1,
            this.menuHelp,
            this.menuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuHelp
            // 
            this.menuHelp.Image = ((System.Drawing.Image)(resources.GetObject("menuHelp.Image")));
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(162, 22);
            this.menuHelp.Tag = "HELP";
            this.menuHelp.Text = "Documentation";
            // 
            // menuAbout
            // 
            this.menuAbout.Image = ((System.Drawing.Image)(resources.GetObject("menuAbout.Image")));
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(162, 22);
            this.menuAbout.Tag = "ABOUT";
            this.menuAbout.Text = "About";
            // 
            // toolStripBind
            // 
            this.toolStripBind.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnRemove,
            this.btnClear,
            this.toolStripLabel1,
            this.btnOptions,
            this.btnHelp,
            this.btnExit});
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
            this.btnAdd.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            this.btnRemove.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            this.btnClear.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // statusStripBind
            // 
            this.statusStripBind.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStripBind.Location = new System.Drawing.Point(0, 301);
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
            this.tabControlBind.Size = new System.Drawing.Size(579, 252);
            this.tabControlBind.TabIndex = 3;
            // 
            // tabPageNewBind
            // 
            this.tabPageNewBind.Controls.Add(this.btnAddForce);
            this.tabPageNewBind.Controls.Add(this.chkAutoBind);
            this.tabPageNewBind.Controls.Add(this.chkEnableDelay);
            this.tabPageNewBind.Controls.Add(this.cboxLocales);
            this.tabPageNewBind.Controls.Add(this.label6);
            this.tabPageNewBind.Controls.Add(this.cboxIPAddress);
            this.tabPageNewBind.Controls.Add(this.button3);
            this.tabPageNewBind.Controls.Add(this.txtExeFile);
            this.tabPageNewBind.Controls.Add(this.label5);
            this.tabPageNewBind.Controls.Add(this.lblIPAdd);
            this.tabPageNewBind.Controls.Add(this.panel2);
            this.tabPageNewBind.ImageIndex = 0;
            this.tabPageNewBind.Location = new System.Drawing.Point(4, 23);
            this.tabPageNewBind.Name = "tabPageNewBind";
            this.tabPageNewBind.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewBind.Size = new System.Drawing.Size(571, 225);
            this.tabPageNewBind.TabIndex = 0;
            this.tabPageNewBind.Text = "New Bind";
            this.tabPageNewBind.UseVisualStyleBackColor = true;
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
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(513, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 23);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
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
            this.tabPageBindList.Size = new System.Drawing.Size(571, 261);
            this.tabPageBindList.TabIndex = 1;
            this.tabPageBindList.Text = "Bind List";
            this.tabPageBindList.UseVisualStyleBackColor = true;
            // 
            // listViewBind
            // 
            this.listViewBind.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderIP,
            this.columnHeaderPath,
            this.columnHeaderAutoBind,
            this.columnHeaderDesc});
            this.listViewBind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewBind.GridLines = true;
            this.listViewBind.Location = new System.Drawing.Point(3, 33);
            this.listViewBind.Name = "listViewBind";
            this.listViewBind.Size = new System.Drawing.Size(565, 225);
            this.listViewBind.TabIndex = 0;
            this.listViewBind.UseCompatibleStateImageBehavior = false;
            this.listViewBind.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "#";
            this.columnHeaderID.Width = 37;
            // 
            // columnHeaderIP
            // 
            this.columnHeaderIP.Text = "IP Address/GUID";
            this.columnHeaderIP.Width = 114;
            // 
            // columnHeaderPath
            // 
            this.columnHeaderPath.Text = "Path";
            this.columnHeaderPath.Width = 279;
            // 
            // columnHeaderAutoBind
            // 
            this.columnHeaderAutoBind.Text = "Auto Bind";
            this.columnHeaderAutoBind.Width = 62;
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
            this.tabPageCommand.Controls.Add(this.panel1);
            this.tabPageCommand.Controls.Add(this.btnIPConfigRenew);
            this.tabPageCommand.Controls.Add(this.btnIPConfigRelease);
            this.tabPageCommand.Controls.Add(this.btnIPConfig);
            this.tabPageCommand.ImageIndex = 2;
            this.tabPageCommand.Location = new System.Drawing.Point(4, 23);
            this.tabPageCommand.Name = "tabPageCommand";
            this.tabPageCommand.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCommand.Size = new System.Drawing.Size(571, 261);
            this.tabPageCommand.TabIndex = 2;
            this.tabPageCommand.Text = "Commands";
            this.tabPageCommand.UseVisualStyleBackColor = true;
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
            this.label1.Size = new System.Drawing.Size(370, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Predefined basic IP configuration commands executed on command prompt.";
            // 
            // btnIPConfigRenew
            // 
            this.btnIPConfigRenew.Location = new System.Drawing.Point(23, 125);
            this.btnIPConfigRenew.Name = "btnIPConfigRenew";
            this.btnIPConfigRenew.Size = new System.Drawing.Size(103, 23);
            this.btnIPConfigRenew.TabIndex = 2;
            this.btnIPConfigRenew.Text = "ipconfig /renew";
            this.btnIPConfigRenew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIPConfigRenew.UseVisualStyleBackColor = true;
            // 
            // btnIPConfigRelease
            // 
            this.btnIPConfigRelease.Location = new System.Drawing.Point(23, 86);
            this.btnIPConfigRelease.Name = "btnIPConfigRelease";
            this.btnIPConfigRelease.Size = new System.Drawing.Size(103, 23);
            this.btnIPConfigRelease.TabIndex = 1;
            this.btnIPConfigRelease.Text = "ipconfig /release";
            this.btnIPConfigRelease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIPConfigRelease.UseVisualStyleBackColor = true;
            // 
            // btnIPConfig
            // 
            this.btnIPConfig.Location = new System.Drawing.Point(23, 48);
            this.btnIPConfig.Name = "btnIPConfig";
            this.btnIPConfig.Size = new System.Drawing.Size(103, 23);
            this.btnIPConfig.TabIndex = 0;
            this.btnIPConfig.Text = "ipconfig /all";
            this.btnIPConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIPConfig.UseVisualStyleBackColor = true;
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
            // btnOptions
            // 
            this.btnOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOptions.Image")));
            this.btnOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(23, 22);
            this.btnOptions.Tag = "OPTION";
            this.btnOptions.Text = "System options";
            this.btnOptions.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            this.btnAddForce.Text = "Add && Force Bind";
            this.btnAddForce.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddForce.UseVisualStyleBackColor = true;
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
            this.menuAddForce.Size = new System.Drawing.Size(152, 22);
            this.menuAddForce.Tag = "ADD_FORCE";
            this.menuAddForce.Text = "Add && Bind";
            // 
            // menuRemove
            // 
            this.menuRemove.Image = ((System.Drawing.Image)(resources.GetObject("menuRemove.Image")));
            this.menuRemove.Name = "menuRemove";
            this.menuRemove.Size = new System.Drawing.Size(152, 22);
            this.menuRemove.Tag = "REMOVE";
            this.menuRemove.Text = "Remove";
            // 
            // menuClear
            // 
            this.menuClear.Image = ((System.Drawing.Image)(resources.GetObject("menuClear.Image")));
            this.menuClear.Name = "menuClear";
            this.menuClear.Size = new System.Drawing.Size(152, 22);
            this.menuClear.Tag = "CLEAR";
            this.menuClear.Text = "Clear All";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel1.Text = "   ";
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
            this.btnHelp.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            this.btnExit.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            // 
            // menuForceBindIP
            // 
            this.menuForceBindIP.Image = ((System.Drawing.Image)(resources.GetObject("menuForceBindIP.Image")));
            this.menuForceBindIP.Name = "menuForceBindIP";
            this.menuForceBindIP.Size = new System.Drawing.Size(162, 22);
            this.menuForceBindIP.Tag = "FORCEBIND_SITE";
            this.menuForceBindIP.Text = "Force BindIP Site";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // menuExit
            // 
            this.menuExit.Image = ((System.Drawing.Image)(resources.GetObject("menuExit.Image")));
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(152, 22);
            this.menuExit.Tag = "EXIT";
            this.menuExit.Text = "Exit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOptions});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // menuOptions
            // 
            this.menuOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuOptions.Image")));
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Size = new System.Drawing.Size(152, 22);
            this.menuOptions.Tag = "OPTION";
            this.menuOptions.Text = "Options";
            // 
            // columnHeaderDesc
            // 
            this.columnHeaderDesc.Text = "Description";
            // 
            // IPBinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 323);
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
        private System.Windows.Forms.ListView listViewBind;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderIP;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.ColumnHeader columnHeaderAutoBind;
        private System.Windows.Forms.Panel panelBindlist;
        private System.Windows.Forms.TabPage tabPageCommand;
        private System.Windows.Forms.Button btnIPConfig;
        private System.Windows.Forms.Button btnIPConfigRenew;
        private System.Windows.Forms.Button btnIPConfigRelease;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxIPAddress;
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.ColumnHeader columnHeaderDesc;
    }
}

