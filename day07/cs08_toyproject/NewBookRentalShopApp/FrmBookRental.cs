using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace NewBookRentalShopApp
{
    public partial class FrmBookRental : MetroForm
    {
        private bool isNew = false; // UPDATE(false), INSERT(true)
        
        public FrmBookRental()
        {
            InitializeComponent();
        }

        private void FrmLoginUser_Load(object sender, EventArgs e)
        {
            RefreshData(); // bookstbl에서 데이터를 가져오는 부분
            // 콤보박스에 들어가는 데이터를 초기화
            InitInputData(); // 콤보박스, 날짜, NumericUpDown 컨트롤 데이터, 초기화
        }

        private void InitInputData()
        {
            try
            {
            }
            catch (Exception ex)
            {
                                        
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            TxtRentalIdx.Text = TxtMemNames.Text = string.Empty;
            TxtMemberIdx.Text = TxtBookIdx.Text = TxtBookNames.Text = string.Empty;
            TxtMemNames.Focus(); // 순번은 자동증가하기때문에 입력 불가
            DtpRentalDate.Value = DtpReturnDate.Value = DateTime.Now;
 
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
                
            if (string.IsNullOrEmpty(TxtMemNames.Text))
            {
                MessageBox.Show("회원명을 입력하세요.");
                return;
            }

            if (string.IsNullOrEmpty(TxtBookNames.Text))
            {
                MessageBox.Show("대출할 책을 선택하세요.");
                return;
            }

            // 반납일이 1800-01-01이면 반납일에 null 입력


            // 콤보박스는 SelectedIndex가 -1이 되면 안됨

            try
            {
                using (SqlConnection conn = new SqlConnection(helper.common.ConnString))
                {
                    conn.Open();

                    var query = "";
                    if (isNew) //INSERT이면
                    {
                        query = @"INSERT INTO [dbo].[rentaltbl]
                                             ([memberIdx]
                                             ,[bookIdx]
                                             ,[rentalDate]
                                             ,[returnDate])
                                       VALUES
                                             (@memberIdx
                                             ,@bookIdx
                                             ,@rentalDate
                                             ,@returnDate)";
                    }
                    else // UPDATE
                    {
                        query = @"UPDATE [dbo].[rentaltbl]
                                     SET [memberIdx] = @memberIdx
                                        ,[bookIdx] = @bookIdx
                                        ,[rentalDate] = @rentalDate
                                        ,[returnDate] = @returnDate
                                   WHERE rentalIdx = @rentalIdx";
                    } 

                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlParameter prmMemberIdx = new SqlParameter("@MemberIdx", TxtMemberIdx.Text);
                    SqlParameter prmBookIdx = new SqlParameter("@BookIdx", TxtBookIdx.Text);
                    SqlParameter prmRentalDate = new SqlParameter("@RentalDate", DtpRentalDate.Value);


                    // Command에 Parameter를 연결해줘야 함!
                    cmd.Parameters.Add(prmMemberIdx);
                    cmd.Parameters.Add(prmBookIdx);
                    cmd.Parameters.Add(prmRentalDate);

                    var returnDate = ""; // 반납날짜 때문에 추가처리
                    if (DtpReturnDate.Value <= DtpRentalDate.Value) // 대출일보다 반납일이 뒤의 날짜가 되어야 함
                    {
                        returnDate = "";
                    }
                    else
                    {
                        returnDate = DtpReturnDate.Value.ToString("yyyy-MM-dd");
                    }
                    SqlParameter prmReturnDate = new SqlParameter("@returnDate", returnDate);
                    cmd.Parameters.Add(prmReturnDate);


                    if (isNew != true)
                    {
                        SqlParameter prmRentalIdx = new SqlParameter("@RentalIdx", TxtRentalIdx.Text);
                        cmd.Parameters.Add(prmRentalIdx);
                    }             

                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        // this 메시지 박스의 부모창이 누구냐, FrmLoginUser
                        MetroMessageBox.Show(this, "저장성공", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("저장 성공.", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("저장 실패.", "저장", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            catch (Exception ex)
            {

               MetroMessageBox.Show(this, $"오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            TxtRentalIdx.Text = TxtMemNames.Text = string.Empty; // 모든 입력값 삭제
            DtpReturnDate.Value = DateTime.Now;
            RefreshData();
        }


        // 데이터그리뷰에 데이터를 새로부르기
        private void RefreshData()
        {
            using (SqlConnection conn = new SqlConnection(helper.common.ConnString))
            {
                conn.Open();

                var query = @"SELECT r.rentalIdx
                                    ,r.memberIdx
	                                ,m.Names AS memNames
                                    ,r.bookIdx
	                                ,b.Names AS bookNames
                                    ,r.rentalDate
                                    ,r.returnDate
                                FROM rentaltbl AS r
                                JOIN membertbl AS m
                                  ON r.memberIdx = m.memberIdx
                                JOIN bookstbl AS b
                                  ON r.bookIdx = b.bookIdx";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "rentaltbl");  // 대표 테이블이름 사용

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true; // 수정불가
                DgvResult.Columns[0].HeaderText = "대출순번";
                DgvResult.Columns[1].HeaderText = "회원순번";
                DgvResult.Columns[2].HeaderText = "회원명";
                DgvResult.Columns[3].HeaderText = "책순번"; // 구분명 새로추가
                DgvResult.Columns[4].HeaderText = "책제목";
                DgvResult.Columns[5].HeaderText = "대출일";
                DgvResult.Columns[6].HeaderText = "반납일";
                // 각 컬럼 넓이, 컬럼 숨김 지정
                DgvResult.Columns[0].Width = 100;
                DgvResult.Columns[1].Width = 100;
                DgvResult.Columns[3].Width = 90;
                DgvResult.Columns[4].Width = 150;
            }
        }

        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) // 아무것도 선택하지 않으면 -1
            {
                var selData = DgvResult.Rows[e.RowIndex]; // 내가 선택한 인덱스값
                TxtRentalIdx.Text = selData.Cells[0].Value.ToString(); // 대출 순번
                TxtMemberIdx.Text = selData.Cells[1].Value.ToString(); // 회원 순번
                TxtMemNames.Text = selData.Cells[2].Value.ToString(); // 회원명
                TxtBookIdx.Text = selData.Cells[3].Value.ToString(); // 책순번
                TxtBookNames.Text = selData.Cells[4].Value.ToString(); // 책제목
                DtpRentalDate.Value = DateTime.Parse(selData.Cells[5].Value.ToString()); // 대출일
                DtpReturnDate.Value = !string.IsNullOrEmpty(selData.Cells[6].Value.ToString()) ? 
                                      DateTime.Parse(selData.Cells[6].Value.ToString()) : 
                                      DateTime.Parse("1800-01-01"); // 반납안한 날짜
                // 거의 모든 타입에 *.Parse(string) 메서드가 존재
                isNew = false; // UPDATE

                // 콤보박스는 맨 마지막에
            }
        }
        // 숫자만 입력 가능하도록 처리
        private void TxtIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnSearchMember_Click(object sender, EventArgs e)
        {
            PopMember popup = new PopMember();
            popup.StartPosition = FormStartPosition.CenterParent;
            if(popup.ShowDialog() == DialogResult.Yes)
            {
                TxtMemberIdx.Text = helper.common.selMemberIdx;
                TxtMemNames.Text = helper.common.selMemberName;
            }
        }

        private void BtnSearchBook_Click(object sender, EventArgs e)
        {
            PopBook popup = new PopBook();
            popup.StartPosition = FormStartPosition.CenterParent;
            if (popup.ShowDialog() == DialogResult.Yes)
            {
                TxtBookIdx.Text = helper.common.selBookIdx;
                TxtBookNames.Text = helper.common.selBookName;
            }
        }
    }
}
