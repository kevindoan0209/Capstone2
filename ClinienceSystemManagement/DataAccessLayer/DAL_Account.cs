using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DataAccessLayer
{
    public class DAL_Account : DbConection
    {
        public DataTable Login(string userName, string password)
        {
            const String sqlCommand = "select * from Account where Account_Password = @PassWord and Account_UserName = @UserName";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@UserName", userName);
            command.Parameters.AddWithValue("@PassWord", password);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
    }
}
