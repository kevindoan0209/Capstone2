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
        public static int InsertMedicine(string name, string mclass,string usage, string note, int price )
        {
            return _medicine.InsertMedicine(name, mclass, usage, note, price);
        }
        public static int UpdateMedicine(int id, string name, string mclass, string usage, string note, int price)
        {
            return _medicine.UpdateMedicine(id,name, mclass, usage, note, price);
        }
    }
}
