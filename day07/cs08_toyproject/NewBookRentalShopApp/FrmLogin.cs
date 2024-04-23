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
using MetroFramework.Forms;

namespace NewBookRentalShopApp
{
    public partial class FrmLogin : MetroForm
    {
        private bool isLogin = false;
       

        public bool IsLogin {   // 로그인 성공여부 저장 변수
            get { return isLogin; }
            set { isLogin = value;  }
        }
        public FrmLogin()
        {
            InitializeComponent();

            TxtUserId.Text = string.Empty;
            TxtPassword.Text = string.Empty;    
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Application.Exit(); 종료시 종료를 물어보는 다이얼로그가 나타남
            Environment.Exit(0); // 강제종료
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool isfail = false;
            string errMsg = string.Empty;

            if(string.IsNullOrEmpty(TxtUserId.Text))
            {
                isfail = true;
                errMsg += "아이디를 입력하세요.\n";
            }
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                isfail = true;
                errMsg += "비밀번호를 입력하세요.\n";
            }

            if (isfail == true)
            {
                MessageBox.Show(errMsg, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // DB연계
            IsLogin = LoginProcess(); // 로그인이 성공하면 True, 실패하면 False 리턴
            if (IsLogin) this.Close(); // 현재 로그인창 닫기.

        }

        // 로그인 DB처리
        private bool LoginProcess()
        {
            var md5Hash = MD5.Create();
            string userId = TxtUserId.Text; // 현재 DBㄹ 넘기는 값
            string password = TxtPassword.Text;
            string chkUserId = string.Empty; // DB에서 넘어온 값
            string chkPassword = string.Empty;

            /*
            * 1. Connection 생성, 오픈
            * 2. 쿼리 문자열 작성
            * 3. SqlCommand 명령객체 생성
            * 4. SqlParameter 객체 생성
            * 5. Select SqlDataReader 또는 SqlDataSet 객체 사용
            * 6. CUD 작업 SqlCommand.ExecuteQyery()
            * 7. Connection 닫기 
            */
            // 연결문자열(ConnectionString)
            // Data Source=localhost;Initial Catalog=BookRentalShop2024;User ID=sa;Encrypt=False;password = mssql_p@ss
            using (SqlConnection conn = new SqlConnection(helper.common.ConnString))
            {
                conn.Open();
                // @userId, @password 쿼리문 외부에서 변수값을 안전하게 주입함
                string query = @"SELECT userId
	                                  ,[password]
                                  FROM usertbl
                                 WHERE userId = @userId
                                   AND[password] = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                // @userId, @password 파라미터 할당
                SqlParameter PrmUserId = new SqlParameter("@userId", userId);
                SqlParameter Prmpassword = new SqlParameter("@password", helper.common.GetMd5Hash(md5Hash, password));
                cmd.Parameters.Add(PrmUserId);
                cmd.Parameters.Add(Prmpassword);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    chkUserId = reader["userId"] != null ? reader["userId"].ToString() : "-"; // 유저아이디가 null일때 - 변경
                    chkPassword = reader["password"] != null ? reader["password"].ToString() : "-"; // 패스워드가 null일때 - 변경

                    return true;
                }

                else
                {
                    MessageBox.Show("로그인 정보가 없습니다", "DB 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }

            } // using을 사용하면 conn.Close()가 필요없음
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 13 == 엔터키
            {
                BtnLogin_Click(sender, e);
            }
        }

        private void TxtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == 13) // 13 == 엔터키
                {
                TxtPassword.Focus();
                }
             
        }
        
    }
}
