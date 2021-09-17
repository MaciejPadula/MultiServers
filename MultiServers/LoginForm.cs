using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiServers
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
            foreach(string line in File.ReadAllLines("settings.properties"))
            {
                if (line.Contains("NASServers="))
                {
                    String[] spearator = { ";" };
                    string[] serv = line.Replace("NASServers=", "").Split(spearator, StringSplitOptions.RemoveEmptyEntries);
                    foreach(string sing in serv)
                    {
                        SIP.Items.Add(sing);
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            (Tag as InstanceWindow).login(SIP.SelectedItem.ToString(),SLog.Text, SPass.Text);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
