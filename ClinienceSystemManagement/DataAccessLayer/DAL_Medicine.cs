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

        public int InsertMedicine(string name, string mclass, string usage, string note, int price)
        {
            const String sqlCommand = "Insert into Medicine (Medicine_Name,Medicine_Class,Medicine_Usage,Medicine_Note,Medicine_Price) values(@Name, @MClass, @Usage, @Note, @Price)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@MClass", mclass);
            command.Parameters.AddWithValue("@Usage", usage);
            command.Parameters.AddWithValue("@Note", note);
            command.Parameters.AddWithValue("@Price", price);
            return command.ExecuteNonQuery();
        }

        public int UpdateMedicine(int id, string name, string mclass, string usage, string note, int price)
        {
            const String sqlCommand = "Update Medicine set Medicine_Name = @Name, Medicine_Class = @MClass, Medicine_Usage = @Usage ,Medicine_Note = @Note, Medicine_Price = @Price  where Medicine_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@MClass", mclass);
            command.Parameters.AddWithValue("@Usage", usage);
            command.Parameters.AddWithValue("@Note", note);
            command.Parameters.AddWithValue("@Price", price);
            return command.ExecuteNonQuery();
        }
    }
}
