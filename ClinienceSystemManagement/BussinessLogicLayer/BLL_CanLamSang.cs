using DataAccessLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BussinessLogicLayer
{
    public class BLL_CanLamSang
    {
        private static readonly DAL_CanLamSang _canLamSang = new DAL_CanLamSang();
        public static DataTable SelectAll()
        {
            return _canLamSang.SelectALL();
        }
       public static int Them(string tenCanLamSang, string ma, int giaTriNho, int giaTriLon, string tenKhac, string donVi, string danhMuc, string diaChi, string ghiChu, string moTa, string thamChieu, int maNhom)
        {

                return _canLamSang.Them(tenCanLamSang, ma, giaTriNho, giaTriLon, tenKhac, donVi, danhMuc, diaChi, ghiChu, moTa, thamChieu, maNhom);
        }
        public static int CapNhat(string tenCanLamSang, string ma, int giaTriNho, int giaTriLon, string tenKhac, string donVi, string danhMuc, string diaChi, string ghiChu, string moTa, string thamChieu, int maNhom)
        {
            return _canLamSang.CapNhat(tenCanLamSang, ma, giaTriNho, giaTriLon, tenKhac, donVi, danhMuc, diaChi, ghiChu, moTa, thamChieu, maNhom);
        }
    }
}
