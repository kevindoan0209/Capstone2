using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class BLL_Disease
    {
        private static readonly DAL_Disease _disease = new DAL_Disease();
        public static int Insert(string id, string name, string description)
        {
            return _disease.Insert(id, name, description);
        }
        public static int Update(string id, string name, string description)
        {
            return _disease.Update(id, name, description);
        }
    }
}
