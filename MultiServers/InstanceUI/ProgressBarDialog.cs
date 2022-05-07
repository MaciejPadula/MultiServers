using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiServers.InstanceUI
{
    public partial class ProgressBarDialog : Form
    {
        public ProgressBarDialog()
        {
            InitializeComponent();
        }
        public void setMaxValue(int maxVal)
        {
            this.progressBar.Maximum = maxVal;
        }
        public int getMaxValue()
        {
            return this.progressBar.Maximum;
        }
        public int getValue()
        {
            return this.progressBar.Value;
        }
        public void setValue(int val)
        {
            this.progressBar.Value = val;
        }
    }
}
