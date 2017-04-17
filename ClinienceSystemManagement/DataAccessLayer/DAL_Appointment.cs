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
            const String sqlCommand = "Insert into Appointmentss (Appointment_StartDate,Appointment_EndDate,Appointment_Issue,Appointment_Complain,Account_ID_Patient,Account_ID_Doctor) Values(@BeginDate, @EndDate, @Reason, @Complain, @PatientId, @DoctorId)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@BeginDate", beginDate);
            command.Parameters.AddWithValue("@EndDate", endDate);
            command.Parameters.AddWithValue("@Reason", reason);
            command.Parameters.AddWithValue("@Complain", complain);
            command.Parameters.AddWithValue("@PatientId", patientId);
            command.Parameters.AddWithValue("@DoctorId", doctorId);
            return command.ExecuteNonQuery();
        }
        public int DeleteAppointment(int patientId)
        {
            const String sqlCommand = "Delete From Appointmentss where Account_ID_Patient = @patientId";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@patientId", patientId);
            return command.ExecuteNonQuery();
        }
    }
}
