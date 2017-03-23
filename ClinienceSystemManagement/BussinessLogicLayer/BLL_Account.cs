using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;
using System.Data;

namespace BussinessLogicLayer
{
    public class BLL_Account
    {
        private static readonly DAL_Account _account = new DAL_Account();
        public static DataTable Login(string userName, string passWord)
        {
            return _account.Login(userName, passWord);
        }
    }
}
