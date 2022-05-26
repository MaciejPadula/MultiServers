using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using MultiServers.InstanceManagement;

namespace MultiServers.InstanceUI
{
    public partial class Instance : UserControl
    {
        public int type=0;
        private String path;
        private InstanceWindow window;
        InstanceSettings instanceSettings;
        public Instance(String path, int type)
        {
            InitializeComponent();
            instanceSettings = SettingsManager.readInstanceSettings(path);
            this.path = path;

            window = new InstanceWindow(path, type, instanceSettings);
            window.Title.Text = nameLabel.Text;
            window.Text = nameLabel.Text;
            window.Hide();
            openButton.Click += new EventHandler(openInstance);
            try
            {
                background.BackgroundImage = Image.FromFile(path + "\\background.png");
                background.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch
            {

            }
            this.type = type;
            this.nameLabel.Text = instanceSettings.getServerName();
            this.versionLabel.Text = instanceSettings.getServerVersion();
            this.maxRamLabel.Text = instanceSettings.getXmx();
            this.minRamLabel.Text = instanceSettings.getXms();

            nameLabel.MouseEnter += new EventHandler(Instance_MouseEnter);
            versionLabel.MouseEnter += new EventHandler(Instance_MouseEnter);
            label3.MouseEnter += new EventHandler(Instance_MouseEnter);
            label4.MouseEnter += new EventHandler(Instance_MouseEnter);
            label5.MouseEnter += new EventHandler(Instance_MouseEnter);
            maxRamLabel.MouseEnter += new EventHandler(Instance_MouseEnter);
            label7.MouseEnter += new EventHandler(Instance_MouseEnter);
            minRamLabel.MouseEnter += new EventHandler(Instance_MouseEnter);


            nameLabel.MouseLeave += new EventHandler(Instance_MouseLeave);
            versionLabel.MouseLeave += new EventHandler(Instance_MouseLeave);
            label3.MouseLeave += new EventHandler(Instance_MouseLeave);
            label4.MouseLeave += new EventHandler(Instance_MouseLeave);
            label5.MouseLeave += new EventHandler(Instance_MouseLeave);
            maxRamLabel.MouseLeave += new EventHandler(Instance_MouseLeave);
            label7.MouseLeave += new EventHandler(Instance_MouseLeave);
            minRamLabel.MouseLeave += new EventHandler(Instance_MouseLeave);
        }
        public InstanceSettings getInstanceSettings()
        {
            return instanceSettings;
        }
        private void Instance_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(220, 220, 220);
        }

        private void Instance_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 255, 255);
        }
        void openInstance(object sender, EventArgs e)
        {
            window.Show();
        }
        private void remove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Remove", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Directory.Delete(path,true);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Program.program.loadInstances();
            }
            
        }

        private void openInstanceFolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "/open, " + path);
        }
        public void killServer()
        {
            this.window.killServer();
            this.window.Close();
        }
        public string GetPath()
        {
            return path;
        }

        private void Instance_Click(object sender, EventArgs e)
        {
            window.Show();
        }
    }
}
