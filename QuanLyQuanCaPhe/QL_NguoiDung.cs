using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUanLyQuanCaPhe
{
    public class QL_NguoiDung
    {
        public enum LoginResult
        {
            Invailid,
            Disabled,
            Success
        }
        public QL_NguoiDung() { }
        public int Check_Config()
        {
            if (Properties.Settings.Default.cnn == String.Empty)
            {
                return 1;
            }
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnn);
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                return 0;
            }
            catch
            {
                return 2;
            }
        }
        public LoginResult Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("SELECT * FROM QL_NguoiDung where TenDangNhap='" + pUser + "' and MatKhau ='" + pPass + "'", Properties.Settings.Default.cnn);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return LoginResult.Invailid; //user k ton tai
            }
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "False")
            {
                return LoginResult.Disabled; // khong hoat dong 
            }
            return LoginResult.Success;//ton tai 
        }
    }
}
