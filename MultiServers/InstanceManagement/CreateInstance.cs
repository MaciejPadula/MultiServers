using MultiServers.InstanceManagement;
using MultiServers.InstanceUI;
using MultiServers.JSONObjects;
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

namespace MultiServers.InstanceManagement
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
            webClient.Proxy = null;
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(downloadProgress_Changed);
        }
        private void CreateInstance_Load(object sender, EventArgs e)
        {
            downloadProgressLabel.Hide();
            string manifest;
            manifest = webClient.DownloadString("https://launchermeta.mojang.com/mc/game/version_manifest.json");
            JSONObjects.MCRepoJSON.RootObject output = JsonConvert.DeserializeObject<JSONObjects.MCRepoJSON.RootObject>(manifest);
            foreach (JSONObjects.MCRepoJSON.Version ver in output.versions)
            {
                ListViewItem item = new ListViewItem(ver.id);
                item.Tag = ver.url;

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
                versionListView.Items.Add(item);
            }
        }

        void versionSelect(object sender,EventArgs e)
        {
            serverVersion.Text = versionListView.SelectedItems[0].Text;
            serverVersion.Tag = versionListView.SelectedItems[0].Tag;
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
            downloadProgressBar.Show();
            downloadProgressLabel.Show();
            if (!File.Exists("Version\\minecraft_server." + serverVersion.Text+".jar"))
            {
                string mcVersion = webClient.DownloadString(serverVersion.Tag as String);

                JSONObjects.MCVersionJSON.RootObject rootObject = JsonConvert.DeserializeObject<JSONObjects.MCVersionJSON.RootObject>(mcVersion);

                String url = "";

                if (rootObject.downloads.server != null)
                {
                    url = rootObject.downloads.server.url;
                }
                ControlBox = false;
                try
                {
                    await webClient.DownloadFileTaskAsync(new Uri(url), "Version\\minecraft_server." + serverVersion.Text + ".jar");
                    
                    File.Copy("Version\\minecraft_server." + serverVersion.Text + ".jar", name + "\\minecraft_server." + serverVersion.Text + ".jar");
                }
                catch
                {
                    /*try
                    {
                        String a = "https://s3.amazonaws.com/Minecraft.Download/versions/" + serverVersion.Text + "/minecraft_server." + serverVersion.Text + ".jar";
                        int b = 0;
                        await webClient.DownloadFileTaskAsync(new Uri("https://s3.amazonaws.com/Minecraft.Download/versions/" + serverVersion.Text + "/minecraft_server." + serverVersion.Text + ".jar"), "Version\\minecraft_server." + serverVersion.Text + ".jar");
                        File.Copy("Version\\minecraft_server." + serverVersion.Text + ".jar", name + "\\minecraft_server." + serverVersion.Text + ".jar");
                    }
                    catch
                    {
                        
                    }*/
                    Directory.Delete(name, true);
                    MessageBox.Show("Cannot create instance of that version","Error");
                }
            }
            else
            {
                File.Copy("Version\\minecraft_server." + serverVersion.Text + ".jar", name + "\\minecraft_server." + serverVersion.Text + ".jar");
            }
            Program.program.loadInstances();
            this.Hide();
            ControlBox = true;
            downloadProgressBar.Hide();
            downloadProgressLabel.Hide();
            serverVersion.Text = "1.2.5";
            serverVersion.Tag = "https://launchermeta.mojang.com/v1/packages/5158765caf1ca14958cb6c45d52c8e09ed9b046c/1.2.5.json";
            serverName.Text = "";
        }
        private void serverVersion_Click(object sender, EventArgs e)
        {
            this.Width= 375;
        }
    }
}
