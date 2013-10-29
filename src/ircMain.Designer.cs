namespace SharpIRC
{
    partial class ircMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ircMain));
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.usernamesListbox = new System.Windows.Forms.ListBox();
            this.ChatBox = new System.Windows.Forms.RichTextBox();
            this.urlTextbox = new System.Windows.Forms.TextBox();
            this.portTextbox = new System.Windows.Forms.TextBox();
            this.channelTextbox = new System.Windows.Forms.TextBox();
            this.nameTexbox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bCIRCGUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutBCIRCGUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.statuslabel = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.altNameTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.creditsTextbox = new System.Windows.Forms.TextBox();
            this.UserDropDown = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.whisperClick = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.UserDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.BackColor = System.Drawing.Color.Black;
            this.MessageTextBox.Enabled = false;
            this.MessageTextBox.ForeColor = System.Drawing.Color.Chartreuse;
            this.MessageTextBox.Location = new System.Drawing.Point(12, 373);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageTextBox.Size = new System.Drawing.Size(794, 20);
            this.MessageTextBox.TabIndex = 0;
            this.MessageTextBox.Click += new System.EventHandler(this.MessageTextBox_Click);
            this.MessageTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageTextBox_KeyDown);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(1033, 400);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(120, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Visible = false;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(840, 393);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(117, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send Command";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Visible = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // usernamesListbox
            // 
            this.usernamesListbox.BackColor = System.Drawing.SystemColors.InfoText;
            this.usernamesListbox.ForeColor = System.Drawing.Color.Red;
            this.usernamesListbox.FormattingEnabled = true;
            this.usernamesListbox.Location = new System.Drawing.Point(686, 38);
            this.usernamesListbox.Name = "usernamesListbox";
            this.usernamesListbox.Size = new System.Drawing.Size(120, 329);
            this.usernamesListbox.TabIndex = 3;
            this.usernamesListbox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.usernamesListbox_MouseUp);
            // 
            // ChatBox
            // 
            this.ChatBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.ChatBox.ForeColor = System.Drawing.Color.LawnGreen;
            this.ChatBox.Location = new System.Drawing.Point(12, 39);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(657, 328);
            this.ChatBox.TabIndex = 4;
            this.ChatBox.Text = resources.GetString("ChatBox.Text");
            this.ChatBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.ChatBox_LinkClicked_1);
            // 
            // urlTextbox
            // 
            this.urlTextbox.BackColor = System.Drawing.SystemColors.InfoText;
            this.urlTextbox.ForeColor = System.Drawing.SystemColors.Menu;
            this.urlTextbox.Location = new System.Drawing.Point(7, 45);
            this.urlTextbox.Name = "urlTextbox";
            this.urlTextbox.Size = new System.Drawing.Size(100, 20);
            this.urlTextbox.TabIndex = 5;
            // 
            // portTextbox
            // 
            this.portTextbox.BackColor = System.Drawing.SystemColors.InfoText;
            this.portTextbox.ForeColor = System.Drawing.SystemColors.Menu;
            this.portTextbox.Location = new System.Drawing.Point(179, 45);
            this.portTextbox.Name = "portTextbox";
            this.portTextbox.Size = new System.Drawing.Size(100, 20);
            this.portTextbox.TabIndex = 6;
            // 
            // channelTextbox
            // 
            this.channelTextbox.BackColor = System.Drawing.SystemColors.InfoText;
            this.channelTextbox.ForeColor = System.Drawing.SystemColors.Menu;
            this.channelTextbox.Location = new System.Drawing.Point(7, 85);
            this.channelTextbox.Name = "channelTextbox";
            this.channelTextbox.Size = new System.Drawing.Size(100, 20);
            this.channelTextbox.TabIndex = 7;
            // 
            // nameTexbox
            // 
            this.nameTexbox.BackColor = System.Drawing.SystemColors.InfoText;
            this.nameTexbox.ForeColor = System.Drawing.SystemColors.Menu;
            this.nameTexbox.Location = new System.Drawing.Point(179, 85);
            this.nameTexbox.Name = "nameTexbox";
            this.nameTexbox.Size = new System.Drawing.Size(100, 20);
            this.nameTexbox.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bCIRCGUIToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.hideOptionsToolStripMenuItem,
            this.showOptionsToolStripMenuItem,
            this.timeToolStripMenuItem,
            this.quickConnectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1185, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bCIRCGUIToolStripMenuItem
            // 
            this.bCIRCGUIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveChatToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.bCIRCGUIToolStripMenuItem.Name = "bCIRCGUIToolStripMenuItem";
            this.bCIRCGUIToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.bCIRCGUIToolStripMenuItem.Text = "IRC";
            this.bCIRCGUIToolStripMenuItem.Click += new System.EventHandler(this.bCIRCGUIToolStripMenuItem_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("connectToolStripMenuItem.Image")));
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("disconnectToolStripMenuItem.Image")));
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem2.Text = "_______";
            // 
            // saveChatToolStripMenuItem
            // 
            this.saveChatToolStripMenuItem.Name = "saveChatToolStripMenuItem";
            this.saveChatToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveChatToolStripMenuItem.Text = "Save Chat";
            this.saveChatToolStripMenuItem.Click += new System.EventHandler(this.saveChatToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutBCIRCGUIToolStripMenuItem,
            this.websiteToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.manualToolStripMenuItem,
            this.changelogToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutBCIRCGUIToolStripMenuItem
            // 
            this.aboutBCIRCGUIToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutBCIRCGUIToolStripMenuItem.Image")));
            this.aboutBCIRCGUIToolStripMenuItem.Name = "aboutBCIRCGUIToolStripMenuItem";
            this.aboutBCIRCGUIToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aboutBCIRCGUIToolStripMenuItem.Text = "About SharpIRC";
            this.aboutBCIRCGUIToolStripMenuItem.Click += new System.EventHandler(this.aboutBCIRCGUIToolStripMenuItem_Click);
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("websiteToolStripMenuItem.Image")));
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.websiteToolStripMenuItem.Text = "Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            this.changelogToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.changelogToolStripMenuItem.Text = "Changelog";
            this.changelogToolStripMenuItem.Click += new System.EventHandler(this.changelogToolStripMenuItem_Click);
            // 
            // hideOptionsToolStripMenuItem
            // 
            this.hideOptionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hideOptionsToolStripMenuItem.Image")));
            this.hideOptionsToolStripMenuItem.Name = "hideOptionsToolStripMenuItem";
            this.hideOptionsToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.hideOptionsToolStripMenuItem.Text = "Hide Options";
            this.hideOptionsToolStripMenuItem.Visible = false;
            this.hideOptionsToolStripMenuItem.Click += new System.EventHandler(this.hideOptionsToolStripMenuItem_Click);
            // 
            // showOptionsToolStripMenuItem
            // 
            this.showOptionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showOptionsToolStripMenuItem.Image")));
            this.showOptionsToolStripMenuItem.Name = "showOptionsToolStripMenuItem";
            this.showOptionsToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.showOptionsToolStripMenuItem.Text = "Show Options";
            this.showOptionsToolStripMenuItem.Click += new System.EventHandler(this.showOptionsToolStripMenuItem_Click);
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.timeToolStripMenuItem.Text = "time";
            // 
            // quickConnectToolStripMenuItem
            // 
            this.quickConnectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quickConnectToolStripMenuItem.Image")));
            this.quickConnectToolStripMenuItem.Name = "quickConnectToolStripMenuItem";
            this.quickConnectToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.quickConnectToolStripMenuItem.Text = "Quick Connect";
            this.quickConnectToolStripMenuItem.Click += new System.EventHandler(this.quickConnectToolStripMenuItem_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("btnDisconnect.Image")));
            this.btnDisconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisconnect.Location = new System.Drawing.Point(955, 400);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(120, 23);
            this.btnDisconnect.TabIndex = 11;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Visible = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.statuslabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 403);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1185, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabel1.Text = "Status : ";
            // 
            // statuslabel
            // 
            this.statuslabel.ForeColor = System.Drawing.Color.Red;
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(16, 22);
            this.statuslabel.Text = "...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(827, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Save this settings";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(972, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Load the settings from the config file";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(827, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 167);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Options";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(7, 93);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(124, 17);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Notification Sounds?";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(7, 68);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(123, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Shake on new msg?";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Opacity";
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar1.LargeChange = 100;
            this.trackBar1.Location = new System.Drawing.Point(5, 116);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(321, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(7, 44);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(93, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Autoconnect?";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Topmost ?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.altNameTextbox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.urlTextbox);
            this.groupBox2.Controls.Add(this.portTextbox);
            this.groupBox2.Controls.Add(this.channelTextbox);
            this.groupBox2.Controls.Add(this.nameTexbox);
            this.groupBox2.Location = new System.Drawing.Point(827, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 155);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Alt.Nickname";
            // 
            // altNameTextbox
            // 
            this.altNameTextbox.BackColor = System.Drawing.SystemColors.InfoText;
            this.altNameTextbox.ForeColor = System.Drawing.SystemColors.Menu;
            this.altNameTextbox.Location = new System.Drawing.Point(179, 127);
            this.altNameTextbox.Name = "altNameTextbox";
            this.altNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.altNameTextbox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nickname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Channel (with#)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Port (6667 is the default port)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Server URL";
            // 
            // creditsTextbox
            // 
            this.creditsTextbox.Location = new System.Drawing.Point(595, 400);
            this.creditsTextbox.Name = "creditsTextbox";
            this.creditsTextbox.Size = new System.Drawing.Size(339, 20);
            this.creditsTextbox.TabIndex = 18;
            this.creditsTextbox.Text = resources.GetString("creditsTextbox.Text");
            this.creditsTextbox.Visible = false;
            // 
            // UserDropDown
            // 
            this.UserDropDown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whisperClick});
            this.UserDropDown.Name = "UserDropDown";
            this.UserDropDown.Size = new System.Drawing.Size(132, 26);
            this.UserDropDown.Text = "Whisper to";
            // 
            // whisperClick
            // 
            this.whisperClick.Name = "whisperClick";
            this.whisperClick.Size = new System.Drawing.Size(131, 22);
            this.whisperClick.Text = "Whisper to";
            this.whisperClick.Click += new System.EventHandler(this.whisperClick_Click);
            // 
            // ircMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.creditsTextbox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ChatBox);
            this.Controls.Add(this.usernamesListbox);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ircMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.UserDropDown.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox usernamesListbox;
        private System.Windows.Forms.RichTextBox ChatBox;
        private System.Windows.Forms.TextBox urlTextbox;
        private System.Windows.Forms.TextBox portTextbox;
        private System.Windows.Forms.TextBox channelTextbox;
        private System.Windows.Forms.TextBox nameTexbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bCIRCGUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutBCIRCGUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel statuslabel;
        private System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem showOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideOptionsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TextBox creditsTextbox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox altNameTextbox;
        private System.Windows.Forms.ContextMenuStrip UserDropDown;
        private System.Windows.Forms.ToolStripMenuItem whisperClick;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ToolStripMenuItem quickConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveChatToolStripMenuItem;
    }
}

