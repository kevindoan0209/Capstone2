using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL_Allergic:DbConection
    {
        public int InsertAllergic(int typeId, string name, string description, int preId)
        {
            const String sqlCommand = "Insert into Allergic (Allergic_Type_ID,Allergic_Name,Allergic_Note,Precription_ID) Values(@TypeId, @Name, @Description, @PreId)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@TypeId", typeId);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Description", description);
            command.Parameters.AddWithValue("@PreId", preId);
            return command.ExecuteNonQuery();
        }
        public int UpdateAllergic(int typeId, string name, string description, int preId, int id)
        {
            const String sqlCommand = "Update Allergic set Allergic_Type_ID = @TypeId, Allergic_Name = @Name, Allergic_Note = @Description Where Precription_ID = @PreId and Allergic_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@TypeId", typeId);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Description", description);
            command.Parameters.AddWithValue("@PreId", preId);
            command.Parameters.AddWithValue("@Id", id);
            return command.ExecuteNonQuery();
        }
    }
}
