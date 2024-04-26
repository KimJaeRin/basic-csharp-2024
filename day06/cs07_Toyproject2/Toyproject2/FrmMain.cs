using MetroFramework;
using MetroFramework.Forms;
using MyExplorer;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toyproject2
{
    public partial class FrmMain : MetroForm
    {

        public FrmMain()
        {
            InitializeComponent();
        }
        private void PicManStartprm_Click(object sender, EventArgs e)
        {
            Process.Start("control","msconfig.exe");

        }

        private void PicBlu_Click(object sender, EventArgs e)
        {

            Process.Start("control", "bthprops.cpl");

        }

        private void PicTaskManager_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^+{ESC}");
        }
        private void PicDelCash_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show(this, " 인터넷 캐시를 삭제하시겠습니까? ", " 캐시 삭제 ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                MessageBox.Show(this, " 캐시 삭제완료  ", " 캐시 삭제 ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Process.Start("RunDll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 8");
            }
            else return;



        }
        private void PicUsingTime_Click(object sender, EventArgs e)
        {
            FrmUsingTime popup = new FrmUsingTime();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.ShowDialog();
        }

        private void PicTimer_Click(object sender, EventArgs e)
        {
            FrmShutDownTimer popup = new FrmShutDownTimer();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.ShowDialog();
        }
        private void PicSysInfo_Click(object sender, EventArgs e)
        {
            Process.Start("msinfo32.exe");
        }

        private void PicDel_Click(object sender, EventArgs e)
        {
            Process.Start("control", "appwiz.cpl");
        }
        private void PicMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void PicShutDown_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show(this, " 정말 종료하시겠습니까? ", " 시스템 종료 ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("shutdown", "/s /t 0");
            }
            else return;

        }
        private void PicAppInfor_Click(object sender, EventArgs e)
        {
            FrmAbout popup = new FrmAbout();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.ShowDialog();
        }
        private void PicFileSch_Click(object sender, EventArgs e)
        {
            FrmExplorer popup = new FrmExplorer();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.ShowDialog();
        }
        private void PicQuick_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show(this, " 정말 종료하시겠습니까? ", " 프로그램 종료 ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else return;
        }


    }
}

