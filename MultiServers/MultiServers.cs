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
    public partial class MultiServers : Form
    {
        bool activated = true;
        public MultiServers()
        {
            InitializeComponent();
            this.MouseMove += new MouseEventHandler(MouseMove2);
            this.MouseDown += new MouseEventHandler(MouseDown2);
            this.MouseUp += new MouseEventHandler(MouseUp2);

            Title.MouseMove += new MouseEventHandler(MouseMove2);
            Title.MouseDown += new MouseEventHandler(MouseDown2);
            Title.MouseUp += new MouseEventHandler(MouseUp2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("Version"))
            {
                Directory.CreateDirectory("Version");
            }
            try
            {
                loadsettings();
            }
            catch
            {

            }
            dir = Directory.GetCurrentDirectory();
            loadinstances();
            
        }
        public string directory, share;
        void loadsettings()
        {
            foreach (var line in File.ReadAllLines("settings.properties"))
            {
                if (line.Contains("share="))
                {
                    share = line.Replace("share=", "");
                }
                if (line.Contains("dir="))
                {
                    directory = line.Replace("dir=", "");
                }
            }
        }
        string dir = "";
        public void loadinstances()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (string instances in Directory.GetDirectories(dir + "\\Instances\\"))
            {
                Instance inst = new Instance(0);
                foreach (string line in System.IO.File.ReadAllLines(instances+ "\\Instance.info"))
                {
                    if (line.Contains("server-name="))
                    {
                        inst.label1.Text = line.Replace("server-name=", "");
                    }
                    else if (line.Contains("server-version="))
                    {
                        inst.label2.Text = line.Replace("server-version=", "");
                    }
                    else if (line.Contains("xmx="))
                    {
                        inst.label6.Text = line.Replace("xmx=", "") + " MB";
                    }
                    else if (line.Contains("xms="))
                    {
                        inst.label8.Text = line.Replace("xms=", "") + " MB";
                    }
                }
               // inst.Click += new EventHandler(InstanceSelect);
                
                inst.window = new InstanceWindow(instances, inst, inst.type);
                inst.window.Title.Text = inst.label1.Text;
                inst.window.Text = inst.label1.Text;

                inst.Tag = instances;
                inst.OpenButton.Tag = inst;
                inst.OpenButton.Click += new EventHandler(InstanceSelect);
                try
                {
                    inst.BackgroundImage = Image.FromFile(instances + "\\background.png");
                    inst.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch
                {

                }
                flowLayoutPanel1.Controls.Add(inst);
            }
            try
            {
                loadsharedinstances();
            }
            catch
            {

            }
        }

        void InstanceSelect(object sender,EventArgs e)
        {
            Button s = sender as Button;
            Instance ins = s.Tag as Instance;
            ins.window.Show();
            //InstName.Text = s.label1.Text;
            //MaxRam.Text = s.label6.Text;
            //MinRam.Text = s.label8.Text;
            //button3.Tag = s.Tag;
            //label8.Text = s.label2.Text;
            //Jar.Items.Clear();
            //foreach(string jars in Directory.GetFiles(s.Tag.ToString()))
            //{
                //if (jars.Replace(dir, "").Contains(".jar"))
                //{
                   // Jar.Items.Add(jars.Replace(s.Tag.ToString(), "").Replace("\\",""));
                //}
           // }
            //panel1.BringToFront();
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
        
        private void button8_Click(object sender, EventArgs e)
        {
            CreateInstance ci = new CreateInstance();
            ci.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Button obj = sender as Button;
            if (activated)
            {
                obj.BackColor = Color.Tomato;
            }
        }

        private void MultiServers_Deactivate(object sender, EventArgs e)
        {
            Title.BackColor = Color.White;
            Title.ForeColor = Color.Gray;
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Gray;
            button10.BackColor = Color.White;
            button10.ForeColor = Color.Gray;
            iconA.BackColor = Color.White;
            activated = false;
        }

        private void MultiServers_Activated(object sender, EventArgs e)
        {
            Title.BackColor = SystemColors.HotTrack;
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = Color.White;
            button10.BackColor = SystemColors.HotTrack;
            button10.ForeColor = Color.White;
            Title.ForeColor = Color.White;
            iconA.BackColor = SystemColors.HotTrack;
            activated = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button obj = sender as Button;
            if (activated)
            {
                obj.BackColor = SystemColors.HotTrack;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            loadinstances();
        }
        void loadsharedinstances()
        {
            foreach (string instances in Directory.GetDirectories(share + ":\\Instances"))
            {
                Instance inst = new Instance(1);
                foreach (string line in System.IO.File.ReadAllLines(instances + "\\Instance.info"))
                {
                    if (line.Contains("server-name="))
                    {
                        inst.label1.Text = line.Replace("server-name=", "");
                    }
                    else if (line.Contains("server-version="))
                    {
                        inst.label2.Text = line.Replace("server-version=", "");
                    }
                    else if (line.Contains("xmx="))
                    {
                        inst.label6.Text = line.Replace("xmx=", "") + " MB";
                    }
                    else if (line.Contains("xms="))
                    {
                        inst.label8.Text = line.Replace("xms=", "") + " MB";
                    }
                }
                inst.type = 1;
                inst.window = new InstanceWindow(instances, inst, inst.type);
                inst.window.Title.Text = inst.label1.Text;
                inst.window.Text = inst.label1.Text;

                inst.Tag = instances;
                inst.OpenButton.Tag = inst;
                inst.OpenButton.Click += new EventHandler(InstanceSelect);
                try
                {
                    inst.BackgroundImage = Image.FromFile(instances + "\\background.png");
                    inst.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch
                {

                }
                flowLayoutPanel1.Controls.Add(inst);
            }
        }
    }
}
