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

namespace MultiServers
{
    public partial class CreateInstance : Form
    {
        public CreateInstance()
        {
            InitializeComponent();
            this.Width = 180;
            listView1.Click += new EventHandler(select);
        }
        void select(object sender,EventArgs e)
        {
            button1.Text = listView1.SelectedItems[0].Text;
            button1.Tag = "https://s3.amazonaws.com/Minecraft.Download/versions/" + listView1.SelectedItems[0].Text + "/minecraft_server." + listView1.SelectedItems[0].Text + ".jar";
            this.Width = 180;
        }
        WebClient webClient = new WebClient();
        void change(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Maximum = (int)(e.TotalBytesToReceive);
            progressBar1.Value = (int)e.BytesReceived;
            label1.Text = "" + Math.Round((double)e.BytesReceived / 1048576, 2) + "MB " + "" + Math.Round((double)e.TotalBytesToReceive / 1048576, 2) + "MB";
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            label1.Show();
            if (textBox1.Text == "")
            {
                textBox1.Text = button1.Text;
            }

            string name = "Instances\\" + textBox1.Text;

            
            while (Directory.Exists(name))
            {
                name += "1";
            }
            Directory.CreateDirectory(name);
            List<string> info = new List<string>();
            info.Add("server-name=" + textBox1.Text);
            info.Add("server-version=" + button1.Text);
            info.Add("xmx=1024");
            info.Add("xms=512");
            
            System.IO.File.WriteAllLines(name + "\\Instance.info", info);
            System.IO.File.WriteAllText(name + "\\eula.txt", "eula=true");
            progressBar1.Visible = true;
            if (!File.Exists("Version\\minecraft_server." + button1.Text+".jar"))
            {
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(change);
                try
                {
                    ControlBox = false;
                    await webClient.DownloadFileTaskAsync(new Uri(button1.Tag.ToString()), "Version\\minecraft_server." + button1.Text + ".jar");

                    File.Copy("Version\\minecraft_server." + button1.Text + ".jar", name + "\\minecraft_server." + button1.Text + ".jar");
                }
                catch
                {
                    ControlBox = true;
                    button1.Text = "1.2.5";
                    button1.Tag = "https://s3.amazonaws.com/Minecraft.Download/versions/1.2.5/minecraft_server.1.2.5.jar";
                }
            }
            else
            {
                File.Copy("Version\\minecraft_server." + button1.Text + ".jar", name + "\\minecraft_server." + button1.Text + ".jar");
            }
            Program.program.loadinstances();
            this.Close();
        }

        private void CreateInstance_Load(object sender, EventArgs e)
        {
            label1.Hide();
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
                listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Width= 375;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
