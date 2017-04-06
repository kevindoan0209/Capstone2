using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;


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
        public static int InsertMedicine(string name, string mclass,string usage, string note, int price, int unitid)
        {
            return _medicine.InsertMedicine(name, mclass, usage, note, price, unitid);
        }
        public static int InsertIngredient(string name, string note)
        {
            return _medicine.InsertIngredient(name, note);
        }
        public static int UpdateIngredient(string id, string name, string note)
        {
            return _medicine.UpdateIngredient(id, name, note);
        }
        public static int UpdateMedicine(int id, string name, string mclass, string usage, string note, int price, int unitid)
        {
            return _medicine.UpdateMedicine(id,name, mclass, usage, note, price, unitid);
        }
        public static int InsertMeIn(int meId, int inId, string unit, double content)
        {
            return _medicine.InsertMeIn(meId, inId, unit, content);
        }

        public static int GetLastIdMedicine()
        {
            return _medicine.GetLastIdMedicine();
        }
    }
}
