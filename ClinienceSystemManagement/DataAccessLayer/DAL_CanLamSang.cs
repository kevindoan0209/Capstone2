using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL_CanLamSang:DbConection
    {
        public DataTable SelectALL()
        {
            String sqlCommand = "Select * from Paraclinical_Group";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public int Them(string tenCanLamSang, string ma, int giaTriNho, int giaTriLon, string tenKhac, string donVi, string danhMuc, string diaChi, string ghiChu, string moTa, string thamChieu, int maNhom)
        {
            String sqlCommand = "Insert into Paraclinical (Paraclinical_Name,Paraclinical_ID,Paraclinical_ValueMin,Paraclinical_ValueMax,Paraclinical_AnotherName,Paraclinical_Unit,Paraclinical_Category,Paraclinical_Link,Paraclinical_Note,Paraclinical_Description,Paraclinical_ReferenceValue,Paraclinical_Group_ID) Values(@tenCanLamSang, @ma, @giaTriNho, @giaTriLon, @tenKhac, @donVi, @danhMuc, @diaChi, @ghiChu, @moTa, @thamChieu, @maNhom)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@tenCanLamSang", tenCanLamSang);
            command.Parameters.AddWithValue("@ma", ma);
            command.Parameters.AddWithValue("@giaTriNho", giaTriNho);
            command.Parameters.AddWithValue("@giaTriLon", giaTriLon);
            command.Parameters.AddWithValue("@tenKhac", tenKhac);
            command.Parameters.AddWithValue("@donVi", donVi);
            command.Parameters.AddWithValue("@danhMuc", danhMuc);
            command.Parameters.AddWithValue("@diaChi", diaChi);
            command.Parameters.AddWithValue("@ghiChu", ghiChu);
            command.Parameters.AddWithValue("@moTa", moTa);
            command.Parameters.AddWithValue("@thamChieu", thamChieu);
            command.Parameters.AddWithValue("@maNhom", maNhom);
            return command.ExecuteNonQuery();
        }
    }
}
