using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cpu_Ram_Tracking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float cpuValue = CpuPerformanceCounter.NextValue();
            float ramValue = RamPerformanceCounter.NextValue();
            cpuProgressBar.Value = (int)cpuValue;
            ramProgressBar.Value = (int)ramValue;
            cpuLabel.Text = string.Format("{0:0.00}%", cpuValue);
            ramLabel.Text = string.Format("{0:0.00}%", ramValue);
            trackingChart.Series["CPU"].Points.AddY(cpuValue);
            trackingChart.Series["RAM"].Points.AddY(ramValue);
        }
    }
}
