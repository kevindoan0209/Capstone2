using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL_Ingredient:DbConection
    {
        public int Insert(string id, string name, string note)
        {
            const String sqlCommand = "Insert into Ingredient (Ingredient_ID,Ingredient_Name,Ingredient_Note) Values(@Id, @Name, @Note)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Note", note);
            return command.ExecuteNonQuery();
        }

        public int Update(string id, string name, string note)
        {
            const String sqlCommand = "Update Ingredient set Ingredient_Name = @Name, Ingredient_Note = @Note where Ingredient_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Note", note);
            return command.ExecuteNonQuery();
        }
    }
}
