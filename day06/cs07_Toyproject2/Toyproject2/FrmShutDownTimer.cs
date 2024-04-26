using Bugsnag;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Toyproject2
{
    public partial class FrmShutDownTimer : MetroForm
    {
        private Timer timer;
        private DateTime shutdownTime;

        public FrmShutDownTimer()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // 1초마다 갱신
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = shutdownTime - DateTime.Now;
            if (remainingTime.TotalSeconds > 0)
            {
                textBox1.Text = string.Format($"종료까지 남은 시간: " + remainingTime.ToString(@"hh\:mm\:ss"));
            }
            else
            {
                timer.Stop();
                ShutdownComputer();
            }
        }

        private void ShutdownComputer()
        {
            // 컴퓨터 종료 
            System.Diagnostics.Process.Start("shutdown", "/s /t 0");
        }

        private void buttonStartShutdown_Click(object sender, EventArgs e)
        {
            // 입력 시간 설정
            int hours = (int)numericUpDownHours.Value;
            int minutes = (int)numericUpDownMinutes.Value;
            int seconds = (int)numericUpDownSeconds.Value;
            shutdownTime = DateTime.Now.AddHours(hours).AddMinutes(minutes).AddSeconds(seconds);

          
            timer.Start();
        }

        private void FrmShutDownTimer_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}


