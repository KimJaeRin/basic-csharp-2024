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

        


        private void PicSysInfo_Click(object sender, EventArgs e)
        {

        }

        private void PicManStartprm_Click(object sender, EventArgs e)
        {

        }

        private void PicUsingTime_Click(object sender, EventArgs e)
        {
            FrmUsingTime popup = new FrmUsingTime();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.ShowDialog();
        }

        private void PicDelCash_Click(object sender, EventArgs e)
        {

        }

        private void PicDel_Click(object sender, EventArgs e)
        {
                     
        }

        private void PicBlu_Click(object sender, EventArgs e)
        {
          
        }

       
        private void PicTaskManager_Click(object sender, EventArgs e)
        {

        }

        private void PicTimer_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }
        private void PicMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void PicShutDown_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show(this, " 정말 종료하시겠습니까? ", " 시스템 종료 ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No)
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
            var answer = MessageBox.Show(this, " 정말 종료하시겠습니까? ", " 시스템 종료 ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else return;
            
          
        }
    }
}

