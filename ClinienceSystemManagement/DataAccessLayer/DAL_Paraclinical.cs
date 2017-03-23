using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DataAccessLayer
{
    public class DAL_Paraclinical : DbConection
    {
        public int Insert(string name, string id, double valueMin, double valueMax, string anotherName, string unit, string category, string link, string note, string description, string referenceValue, int groupId)
        {
            const String sqlCommand = "Insert into Paraclinical (Paraclinical_Name,Paraclinical_ID,Paraclinical_ValueMin,Paraclinical_ValueMax,Paraclinical_AnotherName,Paraclinical_Unit,Paraclinical_Category,Paraclinical_Link,Paraclinical_Note,Paraclinical_Description,Paraclinical_ReferenceValue,Paraclinical_Group_ID)  Values(@Name, @Id, @ValueMin, @ValueMax, @AnotherName, @Unit, @Category, @Link, @Note, @Description, @ReferenceValue, @GroupId)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@ValueMin", valueMin);
            command.Parameters.AddWithValue("@ValueMax", valueMax);
            command.Parameters.AddWithValue("@AnotherName", anotherName);
            command.Parameters.AddWithValue("@Unit", unit);
            command.Parameters.AddWithValue("@Category", category);
            command.Parameters.AddWithValue("@Link", link);
            command.Parameters.AddWithValue("@Note", note);
            command.Parameters.AddWithValue("@Description", description);
            command.Parameters.AddWithValue("@ReferenceValue", referenceValue);
            command.Parameters.AddWithValue("@GroupId", groupId);
            return command.ExecuteNonQuery();
        }

        public int Update(string name, string id, double valueMin, double valueMax, string anotherName, string unit, string category, string link, string note, string description, string referenceValue, int groupId)
        {
            const String sqlCommand = "Update Paraclinical set Paraclinical_Name =@Name,Paraclinical_ValueMin =@ValueMin,Paraclinical_ValueMax =@ValueMax,Paraclinical_AnotherName =@AnotherName,Paraclinical_Unit =@Unit,Paraclinical_Category =@Category,Paraclinical_Link =@Link,Paraclinical_Note =@Note,Paraclinical_Description =@Description,Paraclinical_ReferenceValue =@ReferenceValue,Paraclinical_Group_ID =@GroupId where Paraclinical_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@ValueMin", valueMin);
            command.Parameters.AddWithValue("@ValueMax", valueMax);
            command.Parameters.AddWithValue("@AnotherName", anotherName);
            command.Parameters.AddWithValue("@Unit", unit);
            command.Parameters.AddWithValue("@Category", category);
            command.Parameters.AddWithValue("@Link", link);
            command.Parameters.AddWithValue("@Note", note);
            command.Parameters.AddWithValue("@Description", description);
            command.Parameters.AddWithValue("@ReferenceValue", referenceValue);
            command.Parameters.AddWithValue("@GroupId", groupId);
            return command.ExecuteNonQuery();
        }
    }
}
