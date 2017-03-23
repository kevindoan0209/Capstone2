using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL_TaiKhoan:DbConection
    {
        public DataTable DangNhap(string tenDangNhap, string matKhau)
        {
            String sqlCommand = "select * from Account where Account_Password = @MatKhau and Account_UserName = @TenDangNhap";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
            command.Parameters.AddWithValue("@MatKhau", matKhau);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
    }
}
