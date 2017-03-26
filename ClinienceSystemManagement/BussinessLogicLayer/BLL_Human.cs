using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;
using System.Data;

namespace BussinessLogicLayer
{
    public class BLL_Human
    {
        private static readonly DAL_Human _account = new DAL_Human();
        public static DataTable Login(string userName, string passWord)
        {
            return _account.Login(userName, passWord);
        }
        public static int InsertAccount(string name,string username,string password, string image, string signature, int type)
        {
            return _account.InsertAccount(name,username,password,image,signature,type);
        }
        public static int UpdateAccount(int id,string name, string username, string password, string image, string signature, int type)
        {
            return _account.UpdateAccount(id,name, username, password, image, signature, type);
        }
    }
}
