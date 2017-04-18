using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


namespace DataAccessLayer
{
    public class DAL_Precription : DbConection
    {
        public int InsertNewPrecription(string note, DateTime date, int money , int patientId, int doctorId)
        {
            const String sqlCommand = "Insert into Precription (Precription_Note,Precription_Date,Precription_Money,Account_ID_Patient,Account_ID_Doctor) Values(@Note, @Date, @Money, @PatientId, @DoctorId)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Note", note);
            command.Parameters.AddWithValue("@Date", date);
            command.Parameters.AddWithValue("@Money", money);
            command.Parameters.AddWithValue("@PatientId", patientId);
            command.Parameters.AddWithValue("@DoctorId", doctorId);
            return command.ExecuteNonQuery();
        }

        public int UpdatePrecription(int precriptionId, string note, DateTime date, int money, int patientId, int doctorId)
        {
            const String sqlCommand = "Update Precription set Precription_Note= @Note, Precription_Date = @Date, Precription_Money = @Money, Account_ID_Patient = @PatientId , Account_ID_Doctor = @DoctorId Where Precription_ID = @PrecriptionId";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@PrecriptionId", precriptionId);
            command.Parameters.AddWithValue("@Note", note);
            command.Parameters.AddWithValue("@Date", date);
            command.Parameters.AddWithValue("@Money", money);
            command.Parameters.AddWithValue("@PatientId", patientId);
            command.Parameters.AddWithValue("@DoctorId", doctorId);
            return command.ExecuteNonQuery();
        }

        public int InsertPrecriptionMedicine(int precriptionId, int medicineId, int quantity, int discount, string note , int amount)
        {
            const String sqlCommand = "Insert into Precription_Medicine (Precription_ID,Medicine_ID,Quantity,Discount,Note,Amount) Values(@PrecriptionId, @MedicineId, @Quantity, @Discount, @Note, @Amount)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@PrecriptionId", precriptionId);
            command.Parameters.AddWithValue("@MedicineId", medicineId);
            command.Parameters.AddWithValue("@Quantity", quantity);
            command.Parameters.AddWithValue("@Discount", discount);
            command.Parameters.AddWithValue("@Note", note);
            command.Parameters.AddWithValue("@Amount", amount);
            return command.ExecuteNonQuery();
        }
        public int UpdatePrecriptionMedicine(int precriptionId, int medicineId, int quantity, int discount, string note, int amount)
        {
            const String sqlCommand = "Update Precription_Medicine set Quantity = @Quantity, Discount =@Discount, Note = @Note, Amount = @Amount Where Precription_ID = @PrecriptionId and Medicine_ID = @MedicineId";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@PrecriptionId", precriptionId);
            command.Parameters.AddWithValue("@MedicineId", medicineId);
            command.Parameters.AddWithValue("@Quantity", quantity);
            command.Parameters.AddWithValue("@Discount", discount);
            command.Parameters.AddWithValue("@Note", note);
            command.Parameters.AddWithValue("@Amount", amount);
            return command.ExecuteNonQuery();
        }

        public int InsertPrecriptionParaclinical(string paraclinicalId, int precriptionId)
        {
            const String sqlCommand = "Insert into Paraclinical_Medicine (Paraclinical_ID,Precription_ID) Values(@ParaclinicalId, @PrecriptionId)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@ParaclinicalId", paraclinicalId);
            command.Parameters.AddWithValue("@PrecriptionId", precriptionId);
            return command.ExecuteNonQuery();
        }
        public int UpdatePrecriptionParaclinical(string paraclinicalId, int precriptionId)
        {
            const String sqlCommand = "Update Paraclinical_Medicine set  Where Paraclinical_ID = @ParaclinicalId and Precription_ID = @PrecriptionId";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@ParaclinicalId", paraclinicalId);
            command.Parameters.AddWithValue("@PrecriptionId", precriptionId);
            return command.ExecuteNonQuery();
        }

        public int InsertPrecriptionDisease(string diseaseId, int precriptionId , string note)
        {
            const String sqlCommand = "Insert into Precription_Disease (Disease_ID,Precription_ID,Note) Values(@DiseaseId, @PrecriptionId, @Note)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@DiseaseId", diseaseId);
            command.Parameters.AddWithValue("@PrecriptionId", precriptionId);
            command.Parameters.AddWithValue("@Note", note);
            return command.ExecuteNonQuery();
        }
        public int UpdatePrecriptionDisease(string diseaseId, int precriptionId, string note)
        {
            const String sqlCommand = "Update Precription_Disease set Note = @Note Where Precription_ID = @PrecriptionId and Disease_ID = @DiseaseId";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@DiseaseId", diseaseId);
            command.Parameters.AddWithValue("@PrecriptionId", precriptionId);
            command.Parameters.AddWithValue("@Note", note);
            return command.ExecuteNonQuery();
        }

    }
}
