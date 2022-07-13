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

namespace MultiServers.InstanceUI
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
            ControlBox = true;
            downloadProgressBar.Hide();
            downloadProgressLabel.Hide();
            serverVersion.Text = "1.2.5";
            serverVersion.Tag = "http://launchermeta.mojang.com/v1/packages/5158765caf1ca14958cb6c45d52c8e09ed9b046c/1.2.5.json";
            serverName.Text = "";

            createServer.Enabled = true;
            serverVersion.Enabled = true;
            serverName.Enabled = true;
            downloadProgressLabel.Hide();
            try
            {
                string manifest = null;
                manifest = webClient.DownloadString("http://launchermeta.mojang.com/mc/game/version_manifest.json");
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
            catch (Exception ex)
            {
                MessageBox.Show("You cannot create instance without internet connection!", "Error");
                this.Close();
            }
        }

        void versionSelect(object sender,EventArgs e)
        {
            serverVersion.Text = versionListView.SelectedItems[0].Text;
            serverVersion.Tag = versionListView.SelectedItems[0].Tag.ToString().Replace("https", "http");
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
            createServer.Enabled = false;
            serverVersion.Enabled = false;
            serverName.Enabled = false;
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
                string mcVersion = webClient.DownloadString((serverVersion.Tag as String));

                JSONObjects.MCVersionJSON.RootObject rootObject = JsonConvert.DeserializeObject<JSONObjects.MCVersionJSON.RootObject>(mcVersion);

                String url = "";

                if (rootObject.downloads.server != null)
                {
                    url = rootObject.downloads.server.url.Replace("https", "http");
                }
                ControlBox = false;
                try
                {
                    await webClient.DownloadFileTaskAsync(new Uri(url), "Version\\minecraft_server." + serverVersion.Text + ".jar");
                    
                    File.Copy("Version\\minecraft_server." + serverVersion.Text + ".jar", name + "\\minecraft_server." + serverVersion.Text + ".jar");
                }
                catch(Exception ex)
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
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Cannot create instance of that version. If you want to use that verson place server jarfile named minecraft_server.VERSION.jar and try again.", "404 Not found");
                }
            }
            else
            {
                File.Copy("Version\\minecraft_server." + serverVersion.Text + ".jar", name + "\\minecraft_server." + serverVersion.Text + ".jar");
            }
            Program.program.loadInstances();
            this.Hide();
            
        }
        private void serverVersion_Click(object sender, EventArgs e)
        {
            this.Width= 375;
        }
    }
}
