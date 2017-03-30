using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BussinessLogicLayer
{
    public class BLL_Disease
    {
        private static readonly DAL_Disease _disease = new DAL_Disease();
        public static int InsertDisease(string id, string name, string description)
        {
            return _disease.InsertDisease(id, name, description);
        }
        public static int UpdateDisease(string id, string name, string description)
        {
            return _disease.UpdateDisease(id, name, description);
        }
    }
}
