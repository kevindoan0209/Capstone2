using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DataAccessLayer
{
    public class DAL_Appointment:DbConection
    {
        public int InsertNewAppointment(DateTime beginDate, DateTime endDate, string reason, string complain, int patientId, int doctorId)
        {
            const String sqlCommand = "";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@BeginDate", beginDate);
            command.Parameters.AddWithValue("@EndDate", endDate);
            command.Parameters.AddWithValue("@Reason", reason);
            command.Parameters.AddWithValue("@Complain", complain);
            command.Parameters.AddWithValue("@PatientId", patientId);
            command.Parameters.AddWithValue("@DoctorId", doctorId);
            return command.ExecuteNonQuery();
        }
    }
}
