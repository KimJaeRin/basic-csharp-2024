using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace NewBookRentalShopApp
{
    public partial class FrmMain : MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // 폼 로드 이벤트핸들러. 로그인창 Open 시키기
        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.TopMost = true; // 윈도우화면 가장 상단에 오게 함
            frm.ShowDialog();
        }
    }
}
