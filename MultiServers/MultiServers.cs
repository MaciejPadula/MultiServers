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
using MultiServers.InstanceCreation;
using MultiServers.InstanceManagement;
namespace MultiServers
{
    public partial class MultiServers : Form
    {
        public MultiServers()
        {
            InitializeComponent();
        }

        private void MultiServers_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            if (!Directory.Exists("Version"))
            {
                Directory.CreateDirectory("Version");
            }
            if (!Directory.Exists("Instances"))
            {
                Directory.CreateDirectory("Instances");
            }

            Props.mainPath = Directory.GetCurrentDirectory();

            loadInstances();
            
        }
        public void loadInstances()
        {
            instancePanel.Controls.Clear();
            foreach (string instance in Directory.GetDirectories(Props.mainPath + "\\Instances\\"))
            {
                instancePanel.Controls.Add(new Instance(instance, 0));
            }
        }
        private void newInstance_Click(object sender, EventArgs e)
        {
            CreateInstance ci = new CreateInstance();
            ci.ShowDialog();
        }
    }
}
