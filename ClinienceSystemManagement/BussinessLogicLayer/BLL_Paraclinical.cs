using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BussinessLogicLayer
{
    public class BLL_Paraclinical
    {
        private static readonly DAL_Paraclinical _para = new DAL_Paraclinical();
        public static int Insert(string name, string id, int valueMin, int valueMax, string anotherName, string unit, string category, string link, string note, string description, string referenceValue, int groupId)
        {
            return _para.Insert(name, id, valueMin, valueMax, anotherName, unit, category, link, note, description, referenceValue, groupId);
        }
        public static int Update(string name, string id, int valueMin, int valueMax, string anotherName, string unit, string category, string link, string note, string description, string referenceValue, int groupId)
        {
            return _para.Update(name, id, valueMin, valueMax, anotherName, unit, category, link, note, description, referenceValue, groupId);
        }
    }
}
