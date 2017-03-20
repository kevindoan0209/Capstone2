using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using System.Threading.Tasks;
using System.Data;

namespace BussinessLogicLayer
{
    public class BLL_Account
    {
        private static readonly DAL_Account _account = new DAL_Account();
        public static DataTable DangNhap(string TenDangNhap, string MatKhau)
        {
            return _account.DangNhap(TenDangNhap, MatKhau);
        }
    }
}
