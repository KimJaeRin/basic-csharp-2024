
using System.Security;
using System.Security.Cryptography;
using System.Text;


namespace NewBookRentalShopApp.helper
{
    public class common
    {
        // 정적으로 만드는 공통 연결 문자열
        public static readonly string ConnString = "Data Source=localhost;" + "" +
                                    "Initial Catalog=BookRentalShop2024;" + "User ID=sa;"
                                   + "Encrypt=False;password = mssql_p@ss";
        
        // 로그인아이디
        public static string LoginId { get; set; }

        // 회원선택 팝업에서 대출화면으로 넘길 데이터 정적프로퍼티
        public static string selMemberIdx { get; set; }
        public static string selMemberName { get; set; }
        public static string selBookIdx { get; set; }
        public static string selBookName { get; set; }

        // MD5해시 알고리즘 암호화
        // 1234 -> 01011011 -> 110010101101011 -> x65xAEx11..
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // 입력문자열을 byte 배열로 변환한 뒤 MD5 해시처리
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder builder = new StringBuilder(); // 문자열 쉽게 쓸 수 있게 만들어주는 class
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2")); // 16진수 문자로 각 글자를 전부 변환
            }

            return builder.ToString();
        }
    }
}
