using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewBookRentalShopApp
{
    public partial class PopMember : MetroForm   
    {
        public PopMember()
        {
            InitializeComponent();
        }

        private void PopMember_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(helper.common.ConnString))
            {
                conn.Open();

                var query = @"SELECT [memberIdx]
                                    ,[Names]
                                    ,[Levels]
                                    ,[Addr]
                                    ,[Mobile]
                                    ,[Email]
                                FROM [membertbl]";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "membertbl");

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true; // 수정불가
                DgvResult.Columns[0].HeaderText = "회원순번";
                DgvResult.Columns[1].HeaderText = "회원명";
                DgvResult.Columns[2].HeaderText = "회원등급";
                DgvResult.Columns[3].HeaderText = "주소";
                DgvResult.Columns[4].HeaderText = "전화번호";
                DgvResult.Columns[5].HeaderText = "이메일";
                // 각 컬럼 넓이 지정
                DgvResult.Columns[0].Width = 50;
                DgvResult.Columns[1].Width = 60;
                DgvResult.Columns[2].Width = 50;
                DgvResult.Columns[3].Width = 195;
                DgvResult.Columns[4].Width = 110;
                DgvResult.Columns[5].Width = 150;

            }

        }
        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 구현할거 없음
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (DgvResult.SelectedRows == null)
            {
                MessageBox.Show("회원을 선택하세요");
                return;
            }

            var selData = DgvResult.SelectedRows[0];
            helper.common.selMemberIdx = selData.Cells[0].Value.ToString();
            helper.common.selMemberName = selData.Cells[1].Value.ToString();

            this.DialogResult = DialogResult.Yes;  //DialogResult 발생시킴
            this.Close();
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
           this.Close(); // 그냥 닫기
        }

    }
}