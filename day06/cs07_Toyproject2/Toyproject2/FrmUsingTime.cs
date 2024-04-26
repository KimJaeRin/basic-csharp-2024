using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Toyproject2
{
    public partial class FrmUsingTime : MetroForm
    {
        [DllImport("kernel32")]
        private static extern bool GetTickCount64(out ulong tickCount);

        private ulong systemStartTime;

        public FrmUsingTime()
        {
            InitializeComponent();
        }

        private void FrmUsingTime_Load(object sender, EventArgs e)
        {
            // 시스템 시작 시간 가져오기
            GetTickCount64(out systemStartTime);

            // 타이머 시작
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 현재 시간 가져오기
            ulong currentTime;
            

            // 경과 시간 계산 (밀리초 단위)
            ulong elapsedTime = systemStartTime;

            // 시간 형식으로 변환하여 표시
            TimeSpan elapsedSpan = TimeSpan.FromMilliseconds(elapsedTime);
            label1.Text = string.Format($"컴퓨터 켜져 있는 시간: {0}일 {1}시간 {2}분 {3}초", elapsedSpan.Days, elapsedSpan.Hours, elapsedSpan.Minutes, elapsedSpan.Seconds);
        }
    }
}
