using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;
using MetroFramework.Forms;

namespace Toyproject2
{
    public partial class FrmUsingTime : MetroForm
    {
        public FrmUsingTime()
        {
            InitializeComponent();
            DisplaySystemUsage();
            Timer timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        private void DisplaySystemUsage()
        {
            TimeSpan usageTime = TimeSpan.FromMilliseconds((double)Environment.TickCount);
            textBoxUsageTime.Text = string.Format("{0:D2}시간{1:D2}분{2:D2}초",
                usageTime.Hours, usageTime.Minutes, usageTime.Seconds);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            DisplaySystemUsage();
        }
    }
}
