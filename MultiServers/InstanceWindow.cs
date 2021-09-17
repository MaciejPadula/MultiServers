using Renci.SshNet;
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
        Process Server;
        StreamWriter consoleStreamWriter = null;
        delegate void UpdateConsoleWindowDelegate(String msg);
        Instance inst;
        int selectedsettings = 0, type = 0;
        ShellStream shellStream;
        SshClient client;
        bool activated = true;
        public void ShellRunner(object sender, Renci.SshNet.Common.ShellDataEventArgs e)
        {
            try
            {
                String indata = shellStream.Read();
                shellStream.Flush();
                this.Invoke(new Action(() => richTextBox1.Text += indata));
                //richTextBox1.Text += indata;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public InstanceWindow(string path,Instance inst,int type)
        {
            InitializeComponent();
            this.path = path;
            this.inst = inst;
            this.type = type;
            
        }


        /// <summary>
        /// Startowanie servera
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (type == 0)
            {
                string dir = Directory.GetCurrentDirectory();
                Directory.SetCurrentDirectory(path);
                Server = new Process();
                Server.StartInfo.CreateNoWindow = true;
                Server.StartInfo.UseShellExecute = false;

                Server.StartInfo.FileName = "java";
                Server.StartInfo.Arguments = "-jar -Xms" + MinRam.Text + "M -Xmx" + MaxRam.Text + "M " + comboBox1.SelectedItem.ToString() + " nogui";

                Server.StartInfo.RedirectStandardInput = true;
                Server.StartInfo.RedirectStandardOutput = true;
                Server.StartInfo.RedirectStandardError = true;

                Server.OutputDataReceived += new DataReceivedEventHandler(datarecived);
                Server.ErrorDataReceived += new DataReceivedEventHandler(datarecived);

                Server.Start();
                consoleStreamWriter = Server.StandardInput;
                Server.BeginOutputReadLine();
                Server.BeginErrorReadLine();
                Directory.SetCurrentDirectory(dir);
            }
            else if(type==1)
            {
                try
                {
                    shellStream.WriteLine("java -jar -Xms" + MinRam.Text + "M -Xmx" + MaxRam.Text + "M " + comboBox1.SelectedItem.ToString() + " nogui"); shellStream.Flush();
                }
                catch
                {
                    MessageBox.Show("No server.jar selected!");
                }
            }
        }
        void datarecived(object sender, DataReceivedEventArgs e)
        {
            new Thread(delegate() {
            UpdateConsoleWindow(e.Data + "\r\n");
            }).Start();
        }
        

        /// <summary>
        ///Ustawienia serwera!!!
        /// </summary>
        void load_settings()
        {
            try
            {
                foreach (var line in File.ReadAllLines(path + "\\server.properties"))
                {
                    if (line.Contains("server-ip="))
                    {
                        IPAddress.Text = line.Replace("server-ip=","");
                    }
                    if (line.Contains("server-port="))
                    {
                        IPPort.Text = line.Replace("server-port=", "");
                    }
                    if (line.Contains("online-mode="))
                    {
                        OnlineMode.SelectedItem = line.Replace("online-mode=", "");
                    }
                    if (line.Contains("pvp="))
                    {
                        PVP.SelectedItem = line.Replace("pvp=", "");
                    }
                    if (line.Contains("max-players="))
                    {
                        MaxPlayer.Text = line.Replace("max-players=", "");
                    }
                    if (line.Contains("difficulty="))
                    {
                        difficultyCombo.SelectedIndex = int.Parse(line.Replace("difficulty=", ""));
                    }
                    if (line.Contains("allow-flight="))
                    {
                        allowflight.SelectedItem = line.Replace("allow-flight=", "");
                    }
                    if (line.Contains("enable-command-block="))
                    {
                        enablecommandblocks.SelectedItem = line.Replace("enable-command-block=", "");
                    }
                }
            }
            catch
            {

            }
        }
        private void SaveSettings(object sender, EventArgs e)
        {
            try
            {
                List<string> settings = new List<string>();
                settings.Add("server-ip=" + IPAddress.Text);
                settings.Add("server-port=" + IPPort.Text);
                settings.Add("online-mode=" + OnlineMode.SelectedItem.ToString());
                settings.Add("pvp=" + PVP.SelectedItem.ToString());
                settings.Add("max-players=" + MaxPlayer.Text);
                settings.Add("difficulty=" + difficultyCombo.SelectedIndex);
                settings.Add("allow-flight=" + allowflight.SelectedItem.ToString());
                settings.Add("enable-command-block=" + enablecommandblocks.SelectedItem.ToString());
                base.Text = Title.Text;
            
                foreach (var line in File.ReadAllLines(path + "\\server.properties"))
                {
                    if (!line.Contains("enable-command-block=") && !line.Contains("allow-flight=") && !line.Contains("difficulty=") && !line.Contains("server-ip=") && !line.Contains("server-port=") && !line.Contains("online-mode=") && !line.Contains("pvp=") && !line.Contains("max-players="))
                    {
                        settings.Add(line);
                    }

                }
                File.WriteAllLines(path + "\\server.properties", settings);
                saveinstance();
                button4.Hide();
            }
            catch
            {

            }
        }

        void saveinstance()
        {
            ///ZAPISYWANIE USTAWIEN
            List<string> settings = new List<string>();
            settings.Add("server-name=" +Title.Text);
            settings.Add("server-version=" + inst.label2.Text);
            settings.Add("xmx=" + MaxRam.Text);
            settings.Add("xms=" + MinRam.Text);
            try
            {
                settings.Add("server-jar=" + comboBox1.SelectedItem.ToString());
            }
            catch
            {

            }
            File.WriteAllLines(path + "\\Instance.info", settings);

            Program.program.loadinstances();
            this.BringToFront();
        }

        void loadinstsettings()
        {
            MaxRam.Text = inst.label6.Text.Replace(" MB","");
            MinRam.Text = inst.label8.Text.Replace(" MB", "");
            try
            {
                foreach (var line in File.ReadAllLines(path + "\\Instance.info"))
                {
                    if (line.Contains("server-jar="))
                    {
                        comboBox1.SelectedItem = line.Replace("server-jar=","");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Blednie utworzona instancja!");
            }
        }

        /// <summary>
        /// Sekcja zachowania innych obiektow
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            sendcommand(type, textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Select();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void UpdateConsoleWindow(String message)
        {
            //new Thread(new Delegate(){
            try
            {
                if (richTextBox1.InvokeRequired)
                {
                    UpdateConsoleWindowDelegate update = new UpdateConsoleWindowDelegate(UpdateConsoleWindow);
                    richTextBox1.Invoke(update, message);
                }
                else
                {
                    try
                    {
                        richTextBox1.AppendText(message);
                    }
                    catch
                    {
                    }

                }
            }
            catch
            {

            }
        }
        void sendcommand(int t,string text)
        {
            if (t == 0)
            {
                try
                {
                    consoleStreamWriter.WriteLine(text);
                }
                catch
                {
                }
            }
            else if (t == 1)
            {
                try
                {
                    shellStream.WriteLine(text); shellStream.Flush();
                }
                catch
                {
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            sendcommand(type,"stop");
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            if (selectedsettings < settingspanels.Count() - 1) selectedsettings++;
            settingspanels[selectedsettings].BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (selectedsettings > 0) selectedsettings--;
            settingspanels[selectedsettings].BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            Button obj = sender as Button;
            if (activated)
            {
                obj.BackColor = Color.Tomato;
            }
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            Button obj = sender as Button;
            if (activated)
            {
                obj.BackColor = SystemColors.HotTrack;
            }
        }
        /// <summary>
        /// Sekcja zachowania mainforma
        /// </summary>
        List<Panel> settingspanels = new List<Panel>();
        public void login(string ip,string login,string password)
        {
            
            try
            {
                client = new SshClient(ip, login, password);
                client.Connect();
                shellStream = client.CreateShellStream("vt100", 80, 24, 800, 600, 1024);
                shellStream.DataReceived += new EventHandler<Renci.SshNet.Common.ShellDataEventArgs>(ShellRunner);
                shellStream.WriteLine("cd " +'"' +Program.program.directory + path.Replace(Program.program.share + @":\", "").Replace("\\", "/") + '"');
            }
            catch
            {
                
            }
            if (client != null)
            {
                if (!client.IsConnected)
                {
                    LoginForm lf = new LoginForm();

                    lf.Tag = this;
                    lf.ShowDialog();
                }
            }
        }
        private void InstanceWindow_Load(object sender, EventArgs e)
        {
            loadmods();
            settingspanels.Add(instSettings);
            settingspanels.Add(NetworkSettings);
            settingspanels.Add(ServerSettings);
            settingspanels.Add(mods);
            comboBox1.Items.Clear();
            instSettings.BringToFront();
            foreach (var file in Directory.GetFiles(path))
            {
                if (file.Contains(".jar"))
                {
                    
                    comboBox1.Items.Add(file.Replace(path + "\\", ""));
                }
            }

            load_settings();
            loadinstsettings();

            panel1.MouseMove += new MouseEventHandler(MouseMove2);
            panel1.MouseDown += new MouseEventHandler(MouseDown2);
            panel1.MouseUp += new MouseEventHandler(MouseUp2);
            button4.Hide();
            if (type == 1)
            {
                LoginForm lf = new LoginForm();

                lf.Tag = this;
                lf.ShowDialog();
                //richTextBox1.Text = "";

            }
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

        private void Title_TextChanged(object sender, EventArgs e)
        {
            button4.Show();
        }

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

        private void Button9_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "/open, "+ path);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Show();
        }

        private void MaxRam_TextChanged(object sender, EventArgs e)
        {
            button4.Show();
        }

        private void MinRam_TextChanged(object sender, EventArgs e)
        {
            button4.Show();
        }

        private void OnlineMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Show();
        }

        private void IPAddress_TextChanged(object sender, EventArgs e)
        {
            button4.Show();
        }

        private void IPPort_TextChanged(object sender, EventArgs e)
        {
            button4.Show();
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendcommand(type, textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void MaxPlayer_TextChanged(object sender, EventArgs e)
        {
            button4.Show();
        }

        private void PVP_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Show();
        }

        private void InstanceWindow_Activated(object sender, EventArgs e)
        {
            panel1.BackColor = SystemColors.HotTrack;
            button7.BackColor = SystemColors.HotTrack;
            button7.ForeColor = Color.White;
            button10.BackColor = SystemColors.HotTrack;
            button10.ForeColor = Color.White;
            Title.ForeColor = Color.White;
            Title.BackColor = SystemColors.HotTrack;
            iconA.BackColor = SystemColors.HotTrack;
            activated = true;
        }

        private void InstanceWindow_Deactivate(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
            button7.BackColor = Color.White;
            button7.ForeColor = Color.Gray;
            button10.BackColor = Color.White;
            button10.ForeColor = Color.Gray;
            Title.BackColor = Color.White;
            Title.ForeColor = Color.Gray;
            iconA.BackColor = Color.White;
            activated = false;
        }

        private void DifficultyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Show();
        }

        private void Allowflight_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Show();
        }

        private void Enablecommandblocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Show();
        }

        private void InstanceWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { client.Disconnect(); Server.Kill(); } catch { }
            saveinstance();
        }
    }
}
