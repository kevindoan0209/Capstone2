using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL_Patient:DbConection
    {
        public int InsertPatient(int id, int temp, int blood, int pulse, int breath, int weight, int height, int waist, int hip, string note)
        {
            const String sqlCommand = "Insert into Patient (Account_ID,Patient_Temperature,Patient_BloodPressure,Patient_Pulse,Patient_Breathing,Patient_Weight,Patient_Height,Patient_Waist,Patient_Hips,Patient_Note) Values(@Id, @Temp, @Blood, @Pulse, @Breath, @Weight, @Height, @Waist, @Hip, @Note)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Temp", temp);
            command.Parameters.AddWithValue("@Blood", blood);
            command.Parameters.AddWithValue("@Pulse", pulse);
            command.Parameters.AddWithValue("@Breath", breath);
            command.Parameters.AddWithValue("@Weight", weight);
            command.Parameters.AddWithValue("@Height", height);
            command.Parameters.AddWithValue("@Waist", waist);
            command.Parameters.AddWithValue("@Hip", hip);
            command.Parameters.AddWithValue("@Note", note);
            return command.ExecuteNonQuery();
        }

        public int UpdatePatient(int id, int temp, int blood, int pulse, int breath, int weight, int height, int waist, int hip, string note)
        {
            const String sqlCommand = "Update Patient set Patient_Temperature = @Temp , Patient_BloodPressure = @Blood , Patient_Pulse = @Pulse , Patient_Breathing = @Breath , Patient_Weight = @Weight,Patient_Height = @Height,Patient_Waist = @Waist , Patient_Hips = @Hip, Patient_Note = @Note Where Account_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Temp", temp);
            command.Parameters.AddWithValue("@Blood", blood);
            command.Parameters.AddWithValue("@Pulse", pulse);
            command.Parameters.AddWithValue("@Breath", breath);
            command.Parameters.AddWithValue("@Weight", weight);
            command.Parameters.AddWithValue("@Height", height);
            command.Parameters.AddWithValue("@Waist", waist);
            command.Parameters.AddWithValue("@Hip", hip);
            command.Parameters.AddWithValue("@Note", note);
            return command.ExecuteNonQuery();
        }

        public int InsertPatientNoValue(int id)
        {
            const String sqlCommand = "Insert into Patient ( Account_ID) Values(@Id)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            return command.ExecuteNonQuery();
        }

        public int InsertPatientStatus(int id, string complain, string issue)
        {
            const String sqlCommand = "Insert into PatientStatus(Account_ID,PatientStatus_Complain,PatientStatus_Issue) Values(@Id, @Complain, @Issue)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Complain", complain);
            command.Parameters.AddWithValue("@Issue", issue);
            return command.ExecuteNonQuery();
        }
        public int UpdatePatientStatus(int id, string complain, string issue)
        {
            const String sqlCommand = "Update PatientStatus set PatientStatus_Complain = @Complain, PatientStatus_Issue = @Issue  Where Account_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Complain", complain);
            command.Parameters.AddWithValue("@Issue", issue);
            return command.ExecuteNonQuery();
        }
    }
}
