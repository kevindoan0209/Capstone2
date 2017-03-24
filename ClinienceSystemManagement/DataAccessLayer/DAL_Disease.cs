using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL_Disease : DbConection
    {
        public int Insert(string id, string name, string description)
        {
            const String sqlCommand = "Insert into Disease (Disease_ID,Disease_Name,Disease_Description) Values(@Id, @Name, @Description)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Description", description);
            return command.ExecuteNonQuery();
        }

        public int Update(string id, string name, string description)
        {
            const String sqlCommand = "Update Disease set Disease_Name = @Name, Disease_Description = @Description where Disease_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Description", description);
            return command.ExecuteNonQuery();
        }
    }
}

