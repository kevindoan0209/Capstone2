using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class BLL_Medicine
    {
        private static readonly DAL_Medicine _medicine = new DAL_Medicine();
        public static int InsertUnit(string name, string note)
        {
            return _medicine.InsertUnit(name, note);
        }
        public static int UpdateUnit(string id, string name, string note)
        {
            return _medicine.UpdateUnit(id, name, note);
        }
    }
}
