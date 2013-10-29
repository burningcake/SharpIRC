#region License
/**
   _____ _                        _____ _____   _____                   
  / ____| |                      |_   _|  __ \ / ____|                  
 | (___ | |__   __ _ _ __ _ __     | | | |__) | |                       
  \___ \| '_ \ / _` | '__| '_ \    | | |  _  /| |                       
  ____) | | | | (_| | |  | |_) |  _| |_| | \ \| |____                   
 |_____/|_| |_|\__,_|_|  | .__/  |_____|_|  \_\\_____|                  
  _             ____     | |           _                       _        
 | |           |  _ \    |_|          (_)                     | |       
 | |__  _   _  | |_) |_   _ _ __ _ __  _ _ __   __ _  ___ __ _| | _____ 
 | '_ \| | | | |  _ <| | | | '__| '_ \| | '_ \ / _` |/ __/ _` | |/ / _ \
 | |_) | |_| | | |_) | |_| | |  | | | | | | | | (_| | (_| (_| |   <  __/
 |_.__/ \__, | |____/ \__,_|_|  |_| |_|_|_| |_|\__, |\___\__,_|_|\_\___|
         __/ |                                  __/ |                   
        |___/                                  |___/                   

 
 - You are not allowed to remove the company name either the about function
 - In any credits you have to name the following : "Burningcake" "Sandaasu" "Splamy"
 - You are also not allowed to claim this project as your own work without giving proper credits to the above named nicks.
 - Your are not allowed to make money with any piece of this project. 
 - This is a FREEWARE licensed product.
 
 */
#endregion



using System;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using bcirclib;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Collections;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Permissions;
namespace SharpIRC
{

    public partial class ircMain : Form
    {
        private IrcClient p_client;
        public IrcClient client
        {
            get
            {
                return p_client;
            }
            set
            {
                if (p_client != null)
                {
                    p_client.UserJoined -= UserJoined;
                    p_client.ChannelMessage -= ChannelMessage;
                    p_client.UpdateUsers -= UpdateUsers;
                    p_client.ServerMessage -= ServerMessage;
                    p_client.NoticeMessage -= NoticeMessage;
                    p_client.PrivateMessage -= PrivateMessage;
                    p_client.UserNickChange -= UserNickChange;
                    // p_client.UserNickChange -= UserLeft;
                }
                p_client = value;
                //
                p_client.UserJoined += UserJoined;
                p_client.ChannelMessage += ChannelMessage;
                p_client.UpdateUsers += UpdateUsers;
                p_client.ServerMessage += ServerMessage;
                p_client.NoticeMessage += NoticeMessage;
                p_client.PrivateMessage += PrivateMessage;
                p_client.UserNickChange += UserNickChange;
                //p_client.UserNickChange += UserLeft;
            }
        }
        public void saveLog()
        {
            // Create a SaveFileDialog to request a path and file name to save to.
            SaveFileDialog saveFile1 = new SaveFileDialog();

            // Initialize the SaveFileDialog to specify the RTF extension for the file.
            saveFile1.FileName = "sharpIRC - " + DateTime.Now + " - Log";
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            // Determine if the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                ChatBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        public void ping()
        {
            int pingsuccess;
            Ping myPing = new Ping();
            string host = "8.8.8.8";
            byte[] buffer = new byte[32];
            int timeout = 1000;
            PingOptions pingOptions = new PingOptions();

            try
            {
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                if (reply.Status == IPStatus.Success)
                {
                    pingsuccess = 1;
                    ChatBox.AppendText(Environment.NewLine + "Successfully connected to the DNS Server! ");
                }

                else if (reply.Status == IPStatus.TimedOut)
                {
                    
                }
            }

            catch (Exception ex)
            {
               
              //  MessageBox.Show(ex.Message);
                pingsuccess = 0;
              //  ChatBox.AppendText(Environment.NewLine + "No internet connection .. Application will exit automatically in 5 seconds!");
               // connectToolStripMenuItem.Enabled = false;
               // System.Threading.Thread.Sleep(5000);
              //  Application.Exit();
            }

        }
        System.Threading.Thread connection;
        public ircMain()
        {
            InitializeComponent();
        }
        string programmversion = "0.1.2";
        
        public void messagerevievedBeep()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.NewMessage;
           player.Play();

        }
        public void userJoinedBeep()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.UserJoin;
            player.Play();

        }
        public void PMBeep()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.PM;
            player.Play();

        }
        public void ConnectedBeep()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.Connected;
            player.Play();

        }
        public void DisconnectedBeep()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.Disconnect;
            player.Play();

        }
        private void Shake(Form form)
        {
            var original = form.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 10;
            for (int i = 0; i < 10; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = original;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 827;
            ping();

            this.checkBox4.Checked = Properties.Settings.Default.sound;
            this.checkBox3.Checked = Properties.Settings.Default.shake;
            this.TopMost = this.checkBox1.Checked;
           
            this.trackBar1.Value = Properties.Settings.Default.opacity;
            System.Windows.Forms.Form.ActiveForm.Opacity = ((double)(trackBar1.Value) / 100.0); this.checkBox1.Checked = Properties.Settings.Default.TopMost;
            this.altNameTextbox.Text = Properties.Settings.Default.lastaltnick;
            this.urlTextbox.Text = Properties.Settings.Default.lastserver;
            this.portTextbox.Text = Properties.Settings.Default.lastport;
            this.nameTexbox.Text = Properties.Settings.Default.lastnick;
            this.channelTextbox.Text = Properties.Settings.Default.lastchannel;
            this.Text = Application.ProductName +" " + programmversion; //+ " Using Username: " + Environment.UserName;
        }
        private void Start()
        {
            try { client.Connect(); }
            catch (Exception e) { }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            client.SendRAW(MessageTextBox.Text);
        }
        private delegate void _UserNickChange(string olduser, string newuser);
        private void UserNickChange(string olduser, string newuser)
        {
            if (InvokeRequired)
            {
                Invoke(new _UserNickChange(UserNickChange), new object[] {
				olduser,
				newuser
			});
                return;
            }

            output("", olduser + " changed his nick to :  " + newuser, Color.Red, Color.Silver);
        }
        private delegate void _PrivateMessage(string user, string message);
        private void PrivateMessage(string user, string message)
        {
            if (InvokeRequired)
            {
                Invoke(new _PrivateMessage(PrivateMessage), new object[] {
				user,
				message
			});
                return;
            }

            output(message, user + " whispers to you", Color.Red, Color.HotPink);
            if (checkBox3.Checked == true)
            {
                Shake(this);

            }
            if (checkBox4.Checked == true)
            {
                PMBeep();
            }
        }
        private delegate void _ChannelMessage(string user, string message);
        private void ChannelMessage(string user, string message)
        {
            if (InvokeRequired)
            {
                Invoke(new _ChannelMessage(ChannelMessage), new object[] {
				user,
				message
			});
                return;
            }
            output(message, user, Color.Red, Color.LimeGreen);
            if (checkBox3.Checked == true)
            {
                Shake(this);
            }
            if (checkBox4.Checked == true)
            {
                messagerevievedBeep();
            }
        }
        private delegate void _NoticeMessage(string user, string message);
        private void NoticeMessage(string user, string message)
        {
            if (InvokeRequired)
            {
                Invoke(new _NoticeMessage(NoticeMessage), new object[] {
				user,
				message
			});
                return;
            }
            output(message, "NOTICE", Color.DarkGray, Color.Silver);
        }
        private delegate void _ServerMessage(string message);
        private void ServerMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new _ServerMessage(ServerMessage), (object)message);
                return;
            }
            output(message, "SERVER", Color.DarkGray, Color.Silver);
        }
        private delegate void _UserJoined(string user);
        private void UserJoined(string user)
        {
            if (InvokeRequired)
            {
                Invoke(new _UserJoined(UserJoined), (object)user);
                return;
            }
            output("The user " + user + " joined", "SYSTEM", Color.Red, Color.Silver);
            if (checkBox4.Checked == true)
            {
                userJoinedBeep();
            }
        }
        private delegate void _UserLeft(string user);
        private void UserLeft(string user)
        {
            if (InvokeRequired)
            {
                Invoke(new _UserLeft(UserLeft), (object)user);
                return;
            }
            output("The user " + user + " left.", "SYSTEM", Color.Red, Color.Silver);
        }
        private delegate void _UpdateUsers(string[] users);
        private void UpdateUsers(string[] users)
        {
            if (InvokeRequired)
            {
                Invoke(new _UpdateUsers(UpdateUsers), (object)users);
                return;
            }
            usernamesListbox.Items.Clear();
            foreach (string s in users)
            {
                if (!usernamesListbox.Items.Contains(s))
                {
                    usernamesListbox.Items.Add(s);
                }
            }
        }
        private void MessageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                send(MessageTextBox.Text);
                MessageTextBox.Focus();
                MessageTextBox.Select(0, 0);
                ChatBox.ScrollToCaret();
            }
            else
            {
            }
        }
        public void send(string sentText)
        {
            if (sentText.Length >= 5 && sentText.Substring(0, 5).CompareTo("/exit") == 0)
            {
                Application.Exit();
                return;
            }
            else if (sentText.Length >= 6 && sentText.Substring(0, 6).CompareTo("/join ") == 0)
            {
                connect(sentText.Substring(6));
                MessageTextBox.Clear();
                return;
            }
            else if (sentText.Length >= 5 && sentText.Substring(0, 5).CompareTo("/msg ") == 0)
            {
                client.SendRAW("PRIVMSG " + sentText.Substring(5));
            }
            else if (sentText.Length >= 6 && sentText.Substring(0, 6).CompareTo("/nick ") == 0)
            {
                client.SendRAW("NICK " + sentText.Substring(6));
            }
            else if (sentText.Length > 0 && sentText[0] == '/')
            {
                client.SendRAW(sentText.Substring(1));
                //MessageTextBox.Clear();
            }
            else
            {
                client.SendMessage(sentText);
                output(sentText, client.Nick, Color.Red, Color.LimeGreen);
            }
            //   ChatBox.Text = (ChatBox.Text + Environment.NewLine + "<" + client.Nick + ">"  );
            ChatBox.ScrollToCaret();
            MessageTextBox.Clear();
            MessageTextBox.Focus();
        }

        public void output(string text, string user, Color c1, Color c2)
        {
            ChatBox.AppendText(Environment.NewLine);
            ChatBox.SelectionColor = c1;
            ChatBox.SelectedText = "[" + DateTime.Now.ToShortTimeString() + "]" + " <" + user + ">: ";
            // ChatBox.AppendText(Environment.NewLine + text);
            //ChatBox.AppendText(Environment.NewLine);
            ChatBox.SelectionColor = c2;
            ChatBox.SelectedText = text;
            ChatBox.ScrollToCaret();
        }
        public void connect(string name = "")
        {
            if (connection != null)
            {
                client.Disconnect();
                connection.Abort();
            }
            connection = new System.Threading.Thread(Start);
            connection.IsBackground = true;
            if (name.Length == 0)
                client.Channel = channelTextbox.Text;
            else
                client.Channel = name;
            connection.Start();
            statuslabel.Text = "connected... ";
            usernamesListbox.Sorted = true;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You are about to leave the chat. Sure?", "Question", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        private void aboutBCIRCGUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show( Application.ProductName + " "  + programmversion + " Developed by : " + Application.CompanyName);
        }
        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://burningcake.com/about/");
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Disconnecting?", "Question", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                client.Disconnect();
                ChatBox.Clear();
                usernamesListbox.Items.Clear();
                statuslabel.Text = "disconnected... ";
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.lastaltnick = altNameTextbox.Text;
            Properties.Settings.Default.lastserver = urlTextbox.Text;
            Properties.Settings.Default.lastport = portTextbox.Text;
            Properties.Settings.Default.lastnick = nameTexbox.Text;
            Properties.Settings.Default.lastchannel = channelTextbox.Text;
            Properties.Settings.Default.opacity = trackBar1.Value;
            Properties.Settings.Default.shake = checkBox3.Checked;
            Properties.Settings.Default.sound = checkBox4.Checked;
            Properties.Settings.Default.Save();
            this.Width = 835;
            showOptionsToolStripMenuItem.Visible = true;
            hideOptionsToolStripMenuItem.Visible = false;
            ChatBox.AppendText(Environment.NewLine + "Saved your configurations! ;-)");
            ChatBox.ScrollToCaret();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            this.altNameTextbox.Text = Properties.Settings.Default.lastaltnick;
            this.urlTextbox.Text = Properties.Settings.Default.lastserver;
            this.portTextbox.Text = Properties.Settings.Default.lastport;
            this.nameTexbox.Text = Properties.Settings.Default.lastnick;
            this.channelTextbox.Text = Properties.Settings.Default.lastchannel;
            this.checkBox4.Checked = Properties.Settings.Default.sound;
            this.checkBox3.Checked = Properties.Settings.Default.shake;
            this.trackBar1.Value = Properties.Settings.Default.opacity;
            ChatBox.AppendText(Environment.NewLine + "Settings Restored!");

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeToolStripMenuItem.Text = "it's : " + DateTime.Now.ToShortTimeString();
        }
        private void showOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1196;
            showOptionsToolStripMenuItem.Visible = false;
            hideOptionsToolStripMenuItem.Visible = true;
        }
        private void hideOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 835;
            showOptionsToolStripMenuItem.Visible = true;
            hideOptionsToolStripMenuItem.Visible = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                this.TopMost = true;
                Properties.Settings.Default.TopMost = true;
            }
            else
            {
                this.TopMost = false;
                checkBox1.Checked = false;
                Properties.Settings.Default.TopMost = false;
            }
        }
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
               ConnectedBeep();
            }
            if (urlTextbox.Text == "default server")
            {
                MessageBox.Show("Hey listen! You forgot to tell me the server domain name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MessageTextBox.Enabled = true;

            if (altNameTextbox.Text.CompareTo(nameTexbox.Text) == 0)
            {
                MessageBox.Show("Alt.Name and Name are identically, please change dat");
                return;
            }
            ChatBox.Clear();
            client = new IrcClient(urlTextbox.Text, 6667);
            client.Nick = nameTexbox.Text;
            client.AltNick = altNameTextbox.Text;
            connect();
        }
        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageTextBox.Enabled = true;
            DialogResult dialogResult = MessageBox.Show("Disconnecting?", "Question", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                client.Disconnect();
                ChatBox.Clear();
                usernamesListbox.Items.Clear();
                statuslabel.Text = "disconnected... ";
                ChatBox.Clear();
                ChatBox.Text = creditsTextbox.Text;
                if (checkBox4.Checked == true)
                {
                    DisconnectedBeep();
                }

            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
        private void ChatBox_LinkClicked_1(object sender, LinkClickedEventArgs e)
        {
            Process p = new Process();
            p = Process.Start(e.LinkText);
        }
        private void whisperClick_Click(object sender, EventArgs e)
        {
            MessageTextBox.Text = "/msg " + usernamesListbox.SelectedItem + " ";
            MessageTextBox.Select(MessageTextBox.Text.Length, 0);
            MessageTextBox.Focus();

        }

        private void usernamesListbox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                usernamesListbox.SelectedIndex = usernamesListbox.IndexFromPoint(e.Location);
                UserDropDown.Show(usernamesListbox.PointToScreen(e.Location));
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value == 0)
            {
                System.Windows.Forms.Form.ActiveForm.Opacity = 100;
                trackBar1.Value = 100;

            }
            System.Windows.Forms.Form.ActiveForm.Opacity = ((double)(trackBar1.Value) / 100.0);
            Properties.Settings.Default.opacity = trackBar1.Value;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                Properties.Settings.Default.shake = true;
            }
            else
            {

                checkBox1.Checked = false;
                Properties.Settings.Default.shake = false;
            }
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "BCIRC_HELP.rtf";
		if (!System.IO.File.Exists(filename))
            System.IO.File.WriteAllText(filename, Properties.Resources.BCIRC_Help);
		System.Diagnostics.Process.Start(filename);
	}

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                Properties.Settings.Default.sound = true;
            }
            else
            {

                checkBox1.Checked = false;
                Properties.Settings.Default.sound = false;
            }
        }

    
        private void MessageTextBox_Click(object sender, EventArgs e)
        {
            MessageTextBox.Focus();
            MessageTextBox.Select(0, 0);

        }

        private void bCIRCGUIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quickConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                ConnectedBeep();
            }
            if (urlTextbox.Text == "default server")
            {
                MessageBox.Show("Hey listen! You forgot to tell me the server domain name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MessageTextBox.Enabled = true;

            if (altNameTextbox.Text.CompareTo(nameTexbox.Text) == 0)
            {
                MessageBox.Show("Alt.Name and Name are identically, please change that.");
                return;
            }
            ChatBox.Clear();
            client = new IrcClient(urlTextbox.Text, 6667);
            client.Nick = nameTexbox.Text;
            client.AltNick = altNameTextbox.Text;
            connect();
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon..");
        }

        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "Changelog.txt";
            if (!System.IO.File.Exists(filename))
                System.IO.File.WriteAllText(filename, Properties.Resources.Changelog);
            System.Diagnostics.Process.Start(filename);
            ChatBox.AppendText(Environment.NewLine + "Saved the chatlog successfully.");
        }

        private void saveChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveLog();
        }
        

    }

}

