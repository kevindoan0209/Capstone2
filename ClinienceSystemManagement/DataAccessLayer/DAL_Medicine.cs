using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL_Medicine:DbConection
    {
        public int InsertUnit(string name, string note)
        {
            const String sqlCommand = "Insert into Medicine_Unit (Unit_Name,Unit_Note) Values(@Name, @Note)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Note", note);
            return command.ExecuteNonQuery();
        }

        public int UpdateUnit(string id, string name, string note)
        {
            const String sqlCommand = "Update Medicine_Unit set Unit_Name = @Name, Unit_Note = @Note where Unit_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Note", note);
            return command.ExecuteNonQuery();
        }
    }
}
