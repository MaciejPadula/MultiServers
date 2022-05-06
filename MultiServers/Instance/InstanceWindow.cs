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
    public partial class InstanceWindow : Form
    {
        string path;
        Server server;
        InstanceSettings instanceSettings;
        Instance inst;
        int selectedsettings = 0, type = 0;
        bool activated = true;
        List<Panel> settingspanels = new List<Panel>();
        public InstanceWindow(string path, Instance inst, int type)
        {
            InitializeComponent();
            instanceSettings = SettingsManager.readInstanceSettings(path);
            this.path = path;
            this.inst = inst;
            this.type = type;
            server = new Server(path, "", "", "");
            server.DataRead += UpdateConsoleWindow;

            foreach (var file in Directory.GetFiles(path))
            {
                if (file.Contains(".jar"))
                {
                    comboBox1.Items.Add(file.Replace(path + "\\", ""));
                }
            }

            this.IPAddress.Text = instanceSettings.getIpAddress();
            this.IPPort.Text = instanceSettings.getServerPort();
            this.OnlineMode.SelectedIndex = Convert.ToInt32(instanceSettings.getOnlineMode());
            this.enablecommandblocks.SelectedIndex = Convert.ToInt32(instanceSettings.getEnableCommandBlock());
            this.MaxPlayer.Text = instanceSettings.getMaxPlayers().ToString();
            this.PVP.SelectedIndex = Convert.ToInt32(instanceSettings.getPvp());
            this.allowflight.SelectedIndex = Convert.ToInt32(instanceSettings.getAllowFlight());
            this.difficultyCombo.SelectedIndex = instanceSettings.getDifficulty();
            this.MinRam.Text = instanceSettings.getXms();
            this.MaxRam.Text = instanceSettings.getXmx();
            this.comboBox1.SelectedItem = instanceSettings.getJarFile();
        }
        /*TITLE PANEL*/
        private void Minim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Button obj = sender as Button;
            if (activated)
            {
                obj.BackColor = Color.Tomato;
            }
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Button obj = sender as Button;
            if (activated)
            {
                //obj.BackColor = SystemColors.HotTrack;
            }
        }

        /*INSTANCE LOAD*/
        private void InstanceWindow_Load(object sender, EventArgs e)
        {
            loadmods();
            settingspanels.Add(instSettings);
            settingspanels.Add(NetworkSettings);
            settingspanels.Add(ServerSettings);
            settingspanels.Add(mods);
            instSettings.BringToFront();
            

            panel1.MouseMove += new MouseEventHandler(MouseMove2);
            panel1.MouseDown += new MouseEventHandler(MouseDown2);
            panel1.MouseUp += new MouseEventHandler(MouseUp2);
            ApplyButton.Hide();
        }

        void loadmods()
        {
            listView1.Items.Clear();
            try
            {
                foreach (var mod in Directory.GetFiles(path + "\\mods"))
                {
                    ListViewItem lw = new ListViewItem();
                    lw.Tag = mod;
                    lw.SubItems.Add("");
                    lw.SubItems.Add("");
                    lw.SubItems[0].Text = mod.Replace(path + "\\mods\\", "");
                    if (mod.Contains(".disabled"))
                    {
                        lw.SubItems[2].Text = "Disabled";
                    }
                    else
                    {
                        lw.SubItems[2].Text = "Enabled";
                    }
                    listView1.Items.Add(lw);
                }
            }
            catch
            {

            }
        }

        private void SaveSettings(object sender, EventArgs e)
        {
            instanceSettings
                .setAllowFlight(Convert.ToBoolean(allowflight.SelectedIndex))
                .setDifficulty(difficultyCombo.SelectedIndex)
                .setEnableCommandBlock(Convert.ToBoolean(enablecommandblocks.SelectedIndex))
                .setIpAddress(IPAddress.Text)
                .setMaxPlayers(int.Parse(MaxPlayer.Text))
                .setOnlineMode(Convert.ToBoolean(OnlineMode.SelectedIndex))
                .setPvp(Convert.ToBoolean(PVP.SelectedIndex))
                .setServerName(inst.NameLabel.Text)
                .setServerPort(IPPort.Text)
                .setServerVersion(inst.VersionLabel.Text)
                .setXmx(MaxRam.Text)
                .setXms(MinRam.Text)
                .setJarFile(comboBox1.SelectedItem.ToString());

            SettingsManager.saveSettings(path, instanceSettings);
            Program.program.loadinstances();
            this.BringToFront();
            ApplyButton.Hide();
        }

        /// <summary>
        /// Sekcja zachowania innych obiektow
        /// </summary>
        private void Enter_Click(object sender, EventArgs e)
        {
            server.sendCommand(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Select();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void UpdateConsoleWindow(object sender, DataReadEventArgs e)
        {
            richTextBox1.Invoke(new Action(delegate ()
            {
                richTextBox1.AppendText(e.getMessage());
            }));
        }

        /*INSTANCE CONTROL*/
        private void Run_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() != null)
            {
                string dir = Directory.GetCurrentDirectory();
                Directory.SetCurrentDirectory(path);

                //Server.StartInfo.Arguments = "-jar -Xms" + MinRam.Text + "M -Xmx" + MaxRam.Text + "M " + comboBox1.SelectedItem.ToString() + " nogui";
                server
                    .setJarFile(comboBox1.SelectedItem.ToString())
                    .setXMX(MaxRam.Text)
                    .setXMS(MinRam.Text)
                    .runServer();
                
                Directory.SetCurrentDirectory(dir);
            }


        }
        private void Stop_Click(object sender, EventArgs e)
        {
            server.sendCommand("stop");
        }


        /*INSTANCE SETTINGS CONTROL*/
        private void Prev_Click(object sender, EventArgs e)
        {
            if (selectedsettings > 0) selectedsettings--;
            settingspanels[selectedsettings].BringToFront();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (selectedsettings < settingspanels.Count() - 1) selectedsettings++;
            settingspanels[selectedsettings].BringToFront();
        }
        private void Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyButton.Show();
        }


        /*MOVING TITLE*/
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void MouseDown2(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void MouseMove2(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void MouseUp2(object sender, MouseEventArgs e)
        {
            dragging = false;
        }




        /*MODS CONTROL*/
        private void Button8_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selected in listView1.SelectedItems)
            {
                try
                {
                    if (selected.SubItems[2].Text == "Enabled")
                    {
                        File.Move(selected.Tag.ToString(), selected.Tag + ".disabled");
                    }
                    else
                    {
                        File.Move(selected.Tag.ToString(), selected.Tag.ToString().Replace(".disabled", ""));
                    }
                }
                catch
                {

                }
            }
            loadmods();
        }

        private void ListView1_DragDrop(object sender, DragEventArgs e)
        {
            ListView se = sender as ListView;
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            //ParameterizedThreadStart

            foreach (string paths in s)
            {
                string[] splitted = paths.Split('\\');
                File.Copy(paths,path+"\\mods\\"+splitted[splitted.Count()-1]);
            }
            loadmods();
        }

        private void ListView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void OpenDir_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "/open, "+ path);
        }



        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                server.sendCommand(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void InstanceWindow_Activated(object sender, EventArgs e)
        {
            activated = true;
        }

        private void InstanceWindow_Deactivate(object sender, EventArgs e)
        {
            activated = false;
        }

        

        private void InstanceWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            try {
                server.killServer(); 
            } catch { 
            }
        }
    }
}
