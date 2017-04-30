using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class BLL_Report
    {
        private static readonly DAL_Report _report = new DAL_Report();
        public static DataTable ServiceBill(int preId)
        {
            return _report.ServiceBill(preId);
        }

        public static DataTable PrecriptionBill(int preId)
        {
            return _report.PrecriptionBill(preId);
        }

        public static DataTable DiseaseBill(int preId)
        {
            return _report.DiseaseBill(preId);
        }
    }
}
