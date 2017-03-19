using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DbConection
    {
        private static SqlConnection _conection = new SqlConnection(@"SERVER=KEVIN-PC\SQLEXPRESS;DATABASE=iHealth;UID=kevindoan;PWD=123456;");

        //To check whenver the database connection is open
        public static SqlConnection GetConection()
        {
            if (_conection.State == ConnectionState.Closed)
            {
                _conection.Open();
            }
            return _conection;
        }

        //To perform Insert, Update, Delete , etc..
        public static int ExecuteNonQuery(SqlCommand cmd)
        {
            cmd.Connection = GetConection();
            int rowaffected = -1;
            rowaffected = cmd.ExecuteNonQuery();
            _conection.Close();
            return rowaffected;
        }

        //To retrieve a single value from database
        public static object ExecuteScalar(SqlCommand cmd)
        {
            cmd.Connection = GetConection();
            object obj = -1;
            obj = cmd.ExecuteScalar();
            cmd.Connection.Close();
            return obj;
        }

        //To perform select query
        public static DataTable ExecutecuteReader(SqlCommand cmd)
        {
            cmd.Connection = GetConection();
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            _conection.Close();
            return dt;
        }
    }
}
