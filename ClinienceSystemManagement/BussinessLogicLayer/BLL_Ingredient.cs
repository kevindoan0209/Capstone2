using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class BLL_Ingredient
    {
        private static readonly DAL_Ingredient _ingredient = new DAL_Ingredient();
        public static int Insert(string id, string name, string note)
        {
            return _ingredient.Insert(id, name, note);
        }
        public static int Update(string id, string name, string note)
        {
            return _ingredient.Update(id, name, note);
        }
    }
}
