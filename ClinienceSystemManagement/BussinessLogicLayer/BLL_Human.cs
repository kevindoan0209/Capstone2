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
    }
}
