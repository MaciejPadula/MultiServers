using MultiServers.InstanceManagement;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiServers.InstanceCreation
{
    public partial class CreateInstance : Form
    {
        WebClient webClient;
        public CreateInstance()
        {
            InitializeComponent();
            this.Width = 180;
            versionListView.Click += new EventHandler(versionSelect);
            webClient = new WebClient();
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(downloadProgress_Changed);
        }
        private void CreateInstance_Load(object sender, EventArgs e)
        {
            downloadProgressLabel.Hide();
            string manifest;
            manifest = webClient.DownloadString("https://launchermeta.mojang.com/mc/game/version_manifest.json");
            RootObject output = JsonConvert.DeserializeObject<RootObject>(manifest);
            foreach (Version ver in output.versions)
            {

                ListViewItem item = new ListViewItem(ver.id);
                if (ver.id == output.latest.release)
                {
                    item.SubItems.Add("lastest release");
                }
                else if (ver.id == output.latest.snapshot)
                {
                    item.SubItems.Add("lastest snapshot");
                }
                else
                {
                    item.SubItems.Add(ver.type);
                }
                ///MessageBox.Show(ver.url);
                versionListView.Items.Add(item);
            }
        }

        void versionSelect(object sender,EventArgs e)
        {
            serverVersion.Text = versionListView.SelectedItems[0].Text;
            serverVersion.Tag = "https://s3.amazonaws.com/Minecraft.Download/versions/" + versionListView.SelectedItems[0].Text + "/minecraft_server." + versionListView.SelectedItems[0].Text + ".jar";
            this.Width = 180;
        }
        void downloadProgress_Changed(object sender, DownloadProgressChangedEventArgs e)
        {
            downloadProgressBar.Maximum = (int)(e.TotalBytesToReceive);
            downloadProgressBar.Value = (int)e.BytesReceived;
            downloadProgressLabel.Text = "" + Math.Round((double)e.BytesReceived / 1048576, 2) + "MB " + "" + Math.Round((double)e.TotalBytesToReceive / 1048576, 2) + "MB";
        }
        private async void createServer_Click(object sender, EventArgs e)
        {
            downloadProgressLabel.Show();
            if (serverName.Text == "")
            {
                serverName.Text = serverVersion.Text;
            }

            string name = "Instances\\" + serverName.Text;

            
            while (Directory.Exists(name))
            {
                name += "1";
            }
            Directory.CreateDirectory(name);
            List<string> info = new List<string>();
            info.Add("server-name=" + serverName.Text);
            info.Add("server-version=" + serverVersion.Text);
            info.Add("xmx=1024");
            info.Add("xms=512");

            SettingsManager.saveInfo(name, new InstanceSettings()
                .setServerName(serverName.Text)
                .setServerVersion(serverVersion.Text));

            File.WriteAllText(name + "\\eula.txt", "eula=true");
            downloadProgressBar.Visible = true;
            if (!File.Exists("Version\\minecraft_server." + serverVersion.Text+".jar"))
            {
                
                try
                {
                    ControlBox = false;
                    await webClient.DownloadFileTaskAsync(new Uri(serverVersion.Tag.ToString()), "Version\\minecraft_server." + serverVersion.Text + ".jar");
                    File.Copy("Version\\minecraft_server." + serverVersion.Text + ".jar", name + "\\minecraft_server." + serverVersion.Text + ".jar");
                }
                catch
                {
                    ControlBox = true;
                    serverVersion.Text = "1.2.5";
                    serverVersion.Tag = "https://s3.amazonaws.com/Minecraft.Download/versions/1.2.5/minecraft_server.1.2.5.jar";
                }
            }
            else
            {
                File.Copy("Version\\minecraft_server." + serverVersion.Text + ".jar", name + "\\minecraft_server." + serverVersion.Text + ".jar");
            }
            Program.program.loadInstances();
            this.Close();
        }
        private void serverVersion_Click(object sender, EventArgs e)
        {
            this.Width= 375;
        }
    }
}
