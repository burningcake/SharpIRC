using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SharpIRC
{
    public partial class ircServers : Form
    {
        public ircServers()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            IniParser parser = new IniParser(System.IO.Path.Combine(Application.StartupPath, "servers.ini"));
            String URL;
            URL = parser.GetSetting(comboBox1.Text, "URL");
            textBox1.Text = URL;
            String CHANNEL;
            CHANNEL = parser.GetSetting(comboBox1.Text, "CHANNEL");
            textBox2.Text = CHANNEL;
            String PORT;
            PORT = parser.GetSetting(comboBox1.Text, "PORT");
            textBox3.Text = PORT;
            String PrimNick;
            PrimNick = parser.GetSetting(comboBox1.Text, "PrimNick");
            textBox4.Text = PrimNick;
            String AltNick;
            AltNick = parser.GetSetting(comboBox1.Text, "AltNick");
            textBox5.Text = AltNick;

            


        }
    }
}
