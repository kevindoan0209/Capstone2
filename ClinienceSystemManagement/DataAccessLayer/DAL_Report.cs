using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL_Report:DbConection
    {
        public DataTable ServiceBill(int preId)
        {
            SqlCommand command = new SqlCommand("ServiceBill", connect());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PreId", preId);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }

        public DataTable PrecriptionBill(int preId)
        {
            SqlCommand command = new SqlCommand("PrecriptionBill", connect());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PreId", preId);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }

        public DataTable DiseaseBill(int preId)
        {
            SqlCommand command = new SqlCommand("DiseaseBill", connect());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PreId", preId);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
    }
}
