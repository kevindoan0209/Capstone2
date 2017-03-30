using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


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

        public int InsertMedicine(string name, string mclass, string usage, string note, int price,int unitid)
        {
            const String sqlCommand = "Insert into Medicine (Medicine_Name,Medicine_Class,Medicine_Usage,Medicine_Note,Medicine_Price,Unit_ID) values(@Name, @MClass, @Usage, @Note, @Price,@Unitid)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@MClass", mclass);
            command.Parameters.AddWithValue("@Usage", usage);
            command.Parameters.AddWithValue("@Note", note);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@Unitid", unitid);
            return command.ExecuteNonQuery();
        }
        public int InsertIngredient(string id, string name, string note)
        {
            const String sqlCommand = "Insert into Ingredient (Ingredient_ID,Ingredient_Name,Ingredient_Note) Values(@Id, @Name, @Note)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Note", note);
            return command.ExecuteNonQuery();
        }

        public int UpdateIngredient(string id, string name, string note)
        {
            const String sqlCommand = "Update Ingredient set Ingredient_Name = @Name, Ingredient_Note = @Note where Ingredient_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Note", note);
            return command.ExecuteNonQuery();
        }
        public int UpdateMedicine(int id, string name, string mclass, string usage, string note, int price,int unitid)
        {
            const String sqlCommand = "Update Medicine set Medicine_Name = @Name, Medicine_Class = @MClass, Medicine_Usage = @Usage ,Medicine_Note = @Note, Medicine_Price = @Price ,Unit_ID = @Unitid  where Medicine_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@MClass", mclass);
            command.Parameters.AddWithValue("@Usage", usage);
            command.Parameters.AddWithValue("@Note", note);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@Unitid", unitid);
            return command.ExecuteNonQuery();
        }
        public int InsertMeIn(int meId, int inId, string unit, double content)
        {
            const String sqlCommand = "Insert into Medincine_Ingredient (Medicine_ID,Ingredient_ID,Unit,ContentUnit) Values(@MeId, @InId, @Unit,@Content)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@MeId", meId);
            command.Parameters.AddWithValue("@InId", inId);
            command.Parameters.AddWithValue("@Unit", unit);
            command.Parameters.AddWithValue("@Content", content);     
            return command.ExecuteNonQuery();
        }
    }
}
