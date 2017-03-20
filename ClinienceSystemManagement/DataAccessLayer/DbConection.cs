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
        public SqlConnection connect()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-M75UEQH\SQLEXPRESS;Initial Catalog=ClinienceSystemManagement;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connect.Open();
            return connect;
        }
 
        //public static sqlconnection getconection()
        //{
        //    if (_conection.state == connectionstate.closed)
        //    {
        //        _conection.open();
        //    }
        //    return _conection;
        //}

        //to perform insert, update, delete , etc..
        //public static int executenonquery(sqlcommand cmd)
        //{
        //    cmd.connection = getconection();
        //    int rowaffected = -1;
        //    rowaffected = cmd.executenonquery();
        //    _conection.close();
        //    return rowaffected;
        //}

        //to retrieve a single value from database
        //public static object executescalar(sqlcommand cmd)
        //{
        //    cmd.connection = getconection();
        //    object obj = -1;
        //    obj = cmd.executescalar();
        //    cmd.connection.close();
        //    return obj;
        //}

        //to perform select query
        //public static datatable executecutereader(sqlcommand cmd)
        //{
        //    cmd.connection = getconection();
        //    sqldatareader sdr = cmd.executereader();
        //    datatable dt = new datatable();
        //    dt.load(sdr);
        //    _conection.close();
        //    return dt;
        //}
    }
}
