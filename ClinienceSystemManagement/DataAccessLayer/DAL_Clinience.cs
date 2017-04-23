using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL_Clinience : DbConection
    {
        public int UpdateClinience(String name, String tel, String email, String address, String fax, int cost , int Id)
        {
            const String sqlCommand = "Update Clinience set Clinience_Name = @name, Clinience_Tel = @tel, Clinience_Email = @email, Clinience_Address = @address , Clinience_Fax = @fax, Clinience_Cost = @cost Where Clinience_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@tel", tel);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@fax", fax);
            command.Parameters.AddWithValue("@cost", cost);
            command.Parameters.AddWithValue("@Id", Id);
            return command.ExecuteNonQuery();
        }
        public int UpdateClinienceCost(int Id, int cost)
        {
            const String sqlCommand = "Update Clinience set Clinience_Cost = @Cost where Clinience_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@Cost", cost);     
            return command.ExecuteNonQuery();
        }
    }
}
