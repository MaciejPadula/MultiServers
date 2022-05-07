using MultiServers.InstanceManagement;
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

namespace MultiServers.InstanceUI
{
    public partial class InstanceWindow : Form
    {
        string path;
        Server server;
        
        int selectedsettings = 0, type = 0;
        bool activated = true;
        List<Panel> settingspanels = new List<Panel>();
        InstanceSettings instanceSettings;
        public InstanceWindow(string path, int type, InstanceSettings instanceSettings)
        {
            InitializeComponent();
            this.path = path;
            this.type = type;
            server = new Server(path, "", "", "");
            server.DataRead += UpdateConsoleWindow;

            foreach (var file in Directory.GetFiles(path))
            {
                if (file.Contains(".jar"))
                {
                    jarFileComboBox.Items.Add(file.Replace(path + "\\", ""));
                }
            }
            
        }



        /*INSTANCE LOAD*/
        private void InstanceWindow_Load(object sender, EventArgs e)
        {

            loadSettings();
            loadmods();
            settingspanels.Add(instSettings);
            settingspanels.Add(NetworkSettings);
            settingspanels.Add(ServerSettings);
            settingspanels.Add(mods);
            instSettings.BringToFront();
            

            panel1.MouseMove += new MouseEventHandler(MouseMove2);
            panel1.MouseDown += new MouseEventHandler(MouseDown2);
            panel1.MouseUp += new MouseEventHandler(MouseUp2);
            applyButton.Hide();
        }

        void loadmods()
        {
            modsListView.Items.Clear();
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
                    modsListView.Items.Add(lw);
                }
            }
            catch
            {

            }
        }
        private void loadSettings()
        {
            this.instanceSettings = SettingsManager.readInstanceSettings(path);

            this.ipAddressTextBox.Text = instanceSettings.getIpAddress();
            this.serverPortTextBox.Text = instanceSettings.getServerPort();
            this.onlineModeComboBox.SelectedIndex = Convert.ToInt32(instanceSettings.getOnlineMode());
            this.enableCommandBlocksComboBox.SelectedIndex = Convert.ToInt32(instanceSettings.getEnableCommandBlock());
            this.maxPlayersTextBox.Text = instanceSettings.getMaxPlayers().ToString();
            this.pvpComboBox.SelectedIndex = Convert.ToInt32(instanceSettings.getPvp());
            this.allowFlightComboBox.SelectedIndex = Convert.ToInt32(instanceSettings.getAllowFlight());
            this.difficultyComboBox.SelectedIndex = instanceSettings.getDifficulty();
            this.minRam.Text = instanceSettings.getXms();
            this.maxRam.Text = instanceSettings.getXmx();
            this.jarFileComboBox.SelectedItem = instanceSettings.getJarFile();
            this.Title.Text = instanceSettings.getServerName();
        }
        private void saveSettings(object sender, EventArgs e)
        {
            instanceSettings
                .setAllowFlight(Convert.ToBoolean(allowFlightComboBox.SelectedIndex))
                .setDifficulty(difficultyComboBox.SelectedIndex)
                .setEnableCommandBlock(Convert.ToBoolean(enableCommandBlocksComboBox.SelectedIndex))
                .setIpAddress(ipAddressTextBox.Text)
                .setMaxPlayers(int.Parse(maxPlayersTextBox.Text))
                .setOnlineMode(Convert.ToBoolean(onlineModeComboBox.SelectedIndex))
                .setPvp(Convert.ToBoolean(pvpComboBox.SelectedIndex))
                .setServerName(Title.Text)
                .setServerPort(serverPortTextBox.Text)
                .setXmx(maxRam.Text)
                .setXms(minRam.Text)
                .setJarFile(jarFileComboBox.SelectedItem.ToString());

            SettingsManager.saveSettings(path, instanceSettings);
            SettingsManager.saveInfo(path, instanceSettings);
            Program.program.loadInstances();
            this.BringToFront();
            applyButton.Hide();
        }



        /*INSTANCE CONTROL*/
        private void Enter_Click(object sender, EventArgs e)
        {
            server.sendCommand(inputTextBox.Text);
            inputTextBox.Text = "";
            inputTextBox.Focus();
        }
        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                server.sendCommand(inputTextBox.Text);
                inputTextBox.Text = "";
                inputTextBox.Focus();
            }
        }
        private void serverConsole_TextChanged(object sender, EventArgs e)
        {
            serverConsole.Select();
            serverConsole.SelectionStart = serverConsole.Text.Length;
            serverConsole.ScrollToCaret();
        }

        private void UpdateConsoleWindow(object sender, DataReadEventArgs e)
        {
            serverConsole.Invoke(new Action(delegate ()
            {
                serverConsole.AppendText(e.getMessage());
            }));
        }
        private void run_Click(object sender, EventArgs e)
        {
            if (jarFileComboBox.SelectedItem != null)
            {
                string dir = Directory.GetCurrentDirectory();
                Directory.SetCurrentDirectory(path);

                //Server.StartInfo.Arguments = "-jar -Xms" + MinRam.Text + "M -Xmx" + MaxRam.Text + "M " + comboBox1.SelectedItem.ToString() + " nogui";
                server
                    .setJarFile(jarFileComboBox.SelectedItem.ToString())
                    .setXMX(maxRam.Text)
                    .setXMS(minRam.Text)
                    .runServer();
                
                Directory.SetCurrentDirectory(dir);
            }
            else
            {
                MessageBox.Show("Select server jar file first!", "Warning!");
            }
        }
        public void killServer()
        {
            this.server.killServer();
        }
        private void stop_Click(object sender, EventArgs e)
        {
            server.sendCommand("stop");
            loadSettings();
        }
        


        /*INSTANCE SETTINGS CONTROL*/
        private void prev_Click(object sender, EventArgs e)
        {
            if (selectedsettings > 0) selectedsettings--;
            settingspanels[selectedsettings].BringToFront();
        }
        private void next_Click(object sender, EventArgs e)
        {
            if (selectedsettings < settingspanels.Count() - 1) selectedsettings++;
            settingspanels[selectedsettings].BringToFront();
        }
        private void Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyButton.Show();
        }


        
        /*MODS CONTROL*/
        private void enableDisableMod_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selected in modsListView.SelectedItems)
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
        private void modsListView_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            //ParameterizedThreadStart

            foreach (string paths in s)
            {
                string[] splitted = paths.Split('\\');
                File.Copy(paths,path+"\\mods\\"+splitted[splitted.Count()-1]);
            }
            loadmods();
        }
        private void modsListView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void openDir_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "/open, "+ path);
        }



        

        private void InstanceWindow_Activated(object sender, EventArgs e)
        {
            activated = true;
        }

        private void InstanceWindow_Deactivate(object sender, EventArgs e)
        {
            activated = false;
        }


        /*TITLE PANEL*/
        private void Minim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            /*try
            {
                this.server.killServer();
            }
            catch { }*/
            
            this.Hide();
        }
        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Button obj = sender as Button;
            if (activated)
            {
                obj.BackColor = Color.Tomato;
            }
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



        private void InstanceWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            try {
                
                server.killServer(); 
            } catch { 
            }
        }
    }
}
