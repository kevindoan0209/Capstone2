using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class BLL_Allergic
    {
        private static readonly DAL_Allergic _allergic = new DAL_Allergic();
        public static int InsertAllergic(int typeId, string name, string description, int preId)
        {
            return _allergic.InsertAllergic(typeId, name, description, preId);
        }
        public static int UpdateAllergic(int typeId, string name, string description, int preId, int id)
        {
            return _allergic.UpdateAllergic(typeId, name, description, preId, id);
        }
    }
}
