using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiServers
{
    public partial class MultiServers : Form
    {
        public MultiServers()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            if (!Directory.Exists("Version"))
            {
                Directory.CreateDirectory("Version");
            }
            dir = Directory.GetCurrentDirectory();
            loadinstances();
            
        }
        public string directory;
        string dir = "";
        public void loadinstances()
        {
            InstancePanel.Controls.Clear();
            foreach (string instances in Directory.GetDirectories(dir + "\\Instances\\"))
            {
                Instance inst = new Instance(0);
                foreach (string line in System.IO.File.ReadAllLines(instances+ "\\Instance.info"))
                {
                    if (line.Contains("server-name="))
                    {
                        inst.NameLabel.Text = line.Replace("server-name=", "");
                    }
                    else if (line.Contains("server-version="))
                    {
                        inst.VersionLabel.Text = line.Replace("server-version=", "");
                    }
                    else if (line.Contains("xmx="))
                    {
                        inst.MaxRamLabel.Text = line.Replace("xmx=", "") + " MB";
                    }
                    else if (line.Contains("xms="))
                    {
                        inst.MinRamLabel.Text = line.Replace("xms=", "") + " MB";
                    }
                }
               // inst.Click += new EventHandler(InstanceSelect);
                
                inst.window = new InstanceWindow(instances, inst, inst.type);
                inst.window.Title.Text = inst.NameLabel.Text;
                inst.window.Text = inst.NameLabel.Text;

                inst.Tag = instances;
                inst.OpenButton.Tag = inst;
                inst.OpenButton.Click += new EventHandler(InstanceSelect);
                try
                {
                    inst.background.BackgroundImage = Image.FromFile(instances + "\\background.png");
                    inst.background.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch
                {

                }
                InstancePanel.Controls.Add(inst);
            }
        }

        void InstanceSelect(object sender,EventArgs e)
        {
            Button s = sender as Button;
            Instance ins = s.Tag as Instance;
            ins.window.Show();
        }

        private void NewInstance_Click(object sender, EventArgs e)
        {
            CreateInstance ci = new CreateInstance();
            ci.ShowDialog();
        }
    }
}
