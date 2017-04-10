using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace DataAccessLayer
{
    public class DAL_Human : DbConection
    {
        public DataTable Login(string userName, string password)
        {
            const String sqlCommand = "select * from Account where Account_Password = @PassWord and Account_UserName = @UserName";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@UserName", userName);
            command.Parameters.AddWithValue("@PassWord", password);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }

        public DataTable Select_Username(string username)
        {
            const String sqlCommand = "Select * from Account where Account_UserName = @Username";
            SqlCommand cm = new SqlCommand(sqlCommand, connect());
            cm.Parameters.AddWithValue("@Username", username);
            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }

        public DataTable Select_CheckUserNameSoftware(string username)
        {
            const String sqlCommand = "Select * from Account where Account_UserName = 'admin' and Account_Type_ID <= 3";
            SqlCommand cm = new SqlCommand(sqlCommand, connect());
            cm.Parameters.AddWithValue("@Username", username);
            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }

        public int InsertAccount(string name, string username, string password, string image, string signature, int type)
        {
            const String sqlCommand = "Insert into Account (Account_Name,Account_UserName,Account_Password,Account_Image,Account_Signatures,Account_Type_ID) Values(@Name, @Username, @Password, @Image, @Signature, @Type)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@Image", convertImagetoByte(image));
            command.Parameters.AddWithValue("@Signature", signature);
            command.Parameters.AddWithValue("@Type", type);
            return command.ExecuteNonQuery();
        }
        public int InsertAccountNoImage(string name, string username, string password, string signature, int type)
        {
            const String sqlCommand = "Insert into Account (Account_Name,Account_UserName,Account_Password,Account_Signatures,Account_Type_ID) Values(@Name, @Username, @Password, @Signature, @Type)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@Signature", signature);
            command.Parameters.AddWithValue("@Type", type);
            return command.ExecuteNonQuery();
        }

        public int UpdateAccount(int id, string name, string username, string password, string image, string signature, int type)
        {
            const String sqlCommand = "Update Account set Account_Name = @Name, Account_UserName = @Username, Account_Password = @Password,Account_Image = @Image, Account_Signatures = @Signature, Account_Type_ID = @Type Where Account_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@Image", convertImagetoByte(image));
            command.Parameters.AddWithValue("@Signature", signature);
            command.Parameters.AddWithValue("@Type", type);
            return command.ExecuteNonQuery();
        }

        public int UpdateAccountNoImage(int id, string name, string username, string password, string signature, int type)
        {
            const String sqlCommand = "Update Account set Account_Name = @Name, Account_UserName = @Username, Account_Password = @Password,Account_Signatures = @Signature, Account_Type_ID = @Type Where Account_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@Signature", signature);
            command.Parameters.AddWithValue("@Type", type);
            return command.ExecuteNonQuery();
        }
        public int UpdateAccountPassword(int id, string name,string password)
        {
            const String sqlCommand = "Update Account set Account_Name = @Name, Account_Password = @Password Where Account_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Password", password);
            return command.ExecuteNonQuery();
        }

        public int InsertAccountPatient(string name,string image)
        {
            const String sqlCommand = "Insert into Account (Account_Name,Account_Image) Values(@Name, @Image)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Image", convertImagetoByte(image));
            return command.ExecuteNonQuery();
        }
        public int InsertAccountPatientNoImage(string name)
        {
            const String sqlCommand = "Insert into Account (Account_Name) Values(@Name)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Name", name);
            return command.ExecuteNonQuery();
        }

        public int UpdateAccountPatient(int id, string name,string image)
        {
            const String sqlCommand = "Update Account set Account_Name = @Name,Account_Image = @Image Where Account_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Image", convertImagetoByte(image));
            return command.ExecuteNonQuery();
        }

        public int UpdateAccountPatientNoImage(int id, string name)
        {
            const String sqlCommand = "Update Account set Account_Name = @Name Where Account_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            return command.ExecuteNonQuery();
        }
        public int InsertHumanPatient(int id, DateTime age, string sex, string email, string phone, string job, string city, string address)
        {
            const String sqlCommand = "Insert into Human (Account_ID,Account_Age,Account_Sex,Account_Email,Account_Phone,Account_Job,Account_City,Account_Address) Values(@Id, @Age, @Sex, @Email, @Phone, @Job, @City, @Address)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Age", age);
            command.Parameters.AddWithValue("@Sex", sex);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Job", job);
            command.Parameters.AddWithValue("@City", city);
            command.Parameters.AddWithValue("@Address", address);
            return command.ExecuteNonQuery();
        }
        public int UpdateHumanPatient(int id, DateTime age, string sex, string email, string phone, string job, string city, string address)
        {
            const String sqlCommand = "Update Human set Account_Age = @Age, Account_Sex = @Sex, Account_Email = @Email, Account_Phone = @Phone, Account_Job = @Job, Account_City = @City, Account_Address = @Address Where Account_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Age", age);
            command.Parameters.AddWithValue("@Sex", sex);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Job", job);
            command.Parameters.AddWithValue("@City", city);
            command.Parameters.AddWithValue("@Address", address);
            return command.ExecuteNonQuery();
        }

        public int InsertStatusPatient(string complain, string issue, int accountId)
        {
            const String sqlCommand = "Insert into PatientStatus (PatientStatus_Complain,PatientStatus_Issue,Account_ID) Values(@Complain, @Issue, @AccountId)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Complain", complain);
            command.Parameters.AddWithValue("@Issue", issue);
            command.Parameters.AddWithValue("@AccountId", accountId);
            return command.ExecuteNonQuery();
        }

        public int UpdateStatusPatient(int id, string complain, string issue, int accountId)
        {
            const String sqlCommand = "Update PatientStatus set PatientStatus_Complain = @Complain, PatientStatus_Issue = @Issue , Account_ID = @AccountId  Where PatientStatus_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Complain", complain);
            command.Parameters.AddWithValue("@Issue", issue);
            command.Parameters.AddWithValue("@AccountId", accountId);       
            return command.ExecuteNonQuery();
        }

        private byte[] convertImagetoByte(String image)
        {
            FileStream fs;
            fs = new FileStream(image, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }

        public int GetLastIdAccount()
        {
            const String sqlCommand = "SELECT IDENT_CURRENT('Account') as LastID";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            int temp = int.Parse(command.ExecuteScalar().ToString());
            return temp;
        }
    }
}
