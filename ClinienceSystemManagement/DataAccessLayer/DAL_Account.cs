using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL_Account:DbConection
    {
        public DataTable DangNhap(string TenDangNhap, string MatKhau)
        {
            SqlCommand command = new SqlCommand("Account_Select_DangNhap", connect());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            command.Parameters.AddWithValue("@MatKhau", MatKhau);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
    }
}
