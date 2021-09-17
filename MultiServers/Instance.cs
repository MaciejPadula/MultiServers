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

namespace MultiServers
{
    public partial class Instance : UserControl
    {
        public int type=0;
        public InstanceWindow window;
        public Instance(int type)
        {
            InitializeComponent();
            this.type = type;
            label1.MouseEnter += new EventHandler(Instance_MouseEnter);
            label2.MouseEnter += new EventHandler(Instance_MouseEnter);
            label3.MouseEnter += new EventHandler(Instance_MouseEnter);
            label4.MouseEnter += new EventHandler(Instance_MouseEnter);
            label5.MouseEnter += new EventHandler(Instance_MouseEnter);
            label6.MouseEnter += new EventHandler(Instance_MouseEnter);
            label7.MouseEnter += new EventHandler(Instance_MouseEnter);
            label8.MouseEnter += new EventHandler(Instance_MouseEnter);


            label1.MouseLeave += new EventHandler(Instance_MouseLeave);
            label2.MouseLeave += new EventHandler(Instance_MouseLeave);
            label3.MouseLeave += new EventHandler(Instance_MouseLeave);
            label4.MouseLeave += new EventHandler(Instance_MouseLeave);
            label5.MouseLeave += new EventHandler(Instance_MouseLeave);
            label6.MouseLeave += new EventHandler(Instance_MouseLeave);
            label7.MouseLeave += new EventHandler(Instance_MouseLeave);
            label8.MouseLeave += new EventHandler(Instance_MouseLeave);
        }

        private void Instance_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(220, 220, 220);
        }

        private void Instance_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 255, 255);
        }

        private void remove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Remove", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Directory.Delete(this.Tag.ToString(),true);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Program.program.loadinstances();
            }
            
        }

        private void Instance_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "/open, " + this.Tag.ToString());
        }
    }
}
