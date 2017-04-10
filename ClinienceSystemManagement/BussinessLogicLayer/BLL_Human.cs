using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;
using System.Data;

namespace BussinessLogicLayer
{
    public class BLL_Human
    {
        private static readonly DAL_Human _human = new DAL_Human();
        public static DataTable Login(string userName, string passWord)
        {
            return _human.Login(userName, passWord);
        }

        public static int InsertAccount(string name,string username,string password, string image, string signature, int type)
        {
            return _human.InsertAccount(name,username,password,image,signature,type);
        }

        public static int InsertAccountNoImage(string name, string username, string password, string signature, int type)
        {
            return _human.InsertAccountNoImage(name, username, password, signature, type);
        }

        public static int UpdateAccount(int id,string name, string username, string password, string image, string signature, int type)
        {
            return _human.UpdateAccount(id,name, username, password, image, signature, type);
        }

        public static int UpdateAccountNoImage(int id, string name, string username, string password, string signature, int type)
        {
            return _human.UpdateAccountNoImage(id, name, username, password, signature,type);
        }
        public static int UpdateAccountPassword(int id, string name,string password)
        {
            return _human.UpdateAccountPassword(id, name, password);
        }

        public static DataTable Select_Username(string username)
        {
            return _human.Select_Username(username);
        }

        public static DataTable Select_CheckUserNameSoftware(string username)
        {
            return _human.Select_CheckUserNameSoftware(username);
        }

        public static int GetLastIdAccount()
        {
            return _human.GetLastIdAccount();
        }

        public static int InsertAccountPatient(string name,string image)
        {
            return _human.InsertAccountPatient(name,image);
        }

        public static int InsertAccountPatientNoImage(string name)
        {
            return _human.InsertAccountPatientNoImage(name);
        }

        public static int UpdateAccountPatient(int id, string name,string image)
        {
            return _human.UpdateAccountPatient(id, name,image);
        }

        public static int UpdateAccountPatientNoImage(int id, string name)
        {
            return _human.UpdateAccountPatientNoImage(id, name);
        }
        public static int InsertHumanPatient(int id, DateTime age, string sex, string email, string phone, string job, string city, string address )
        {
            return _human.InsertHumanPatient(id,age,sex,email,phone,job,city,address);
        }
        public static int UpdateHumanPatient(int id, DateTime age, string sex, string email, string phone, string job, string city, string address)
        {
            return _human.UpdateHumanPatient(id, age, sex, email, phone, job, city, address);
        }
        public static int InsertStatusPatient(string complain, string issue, int accountId)
        {
            return _human.InsertStatusPatient(complain,issue,accountId);
        }
        public static int UpdateStatusPatient(int id,string complain, string issue)
        {
            return _human.UpdateStatusPatient(id,complain, issue);
        }
    }
}
