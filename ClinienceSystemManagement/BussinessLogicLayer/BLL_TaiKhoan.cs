using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using System.Threading.Tasks;
using System.Data;

namespace BussinessLogicLayer
{
    public class BLL_TaiKhoan
    {
        private static readonly DAL_TaiKhoan _taiKhoan = new DAL_TaiKhoan();
        public static DataTable DangNhap(string tenDangNhap, string matKhau)
        {
            return _taiKhoan.DangNhap(tenDangNhap, matKhau);
        }
    }
}
