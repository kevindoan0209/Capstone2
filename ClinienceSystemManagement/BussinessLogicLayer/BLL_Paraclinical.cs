using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BussinessLogicLayer
{
    public class BLL_Paraclinical
    {
        private static readonly DAL_Paraclinical _paraclinical = new DAL_Paraclinical();
        public static int InsertParaclinical(string name, string id, double valueMin, double valueMax, string anotherName, string unit, string category, string link, string note, string description, string referenceValue, int groupId)
        {
            return _paraclinical.InsertParaclinical(name, id, valueMin, valueMax, anotherName, unit, category, link, note, description, referenceValue, groupId);
        }
        public static int UpdateParaclinical(string name, string id, double valueMin, double valueMax, string anotherName, string unit, string category, string link, string note, string description, string referenceValue, int groupId)
        {
            return _paraclinical.UpdateParaclinical(name, id, valueMin, valueMax, anotherName, unit, category, link, note, description, referenceValue, groupId);
        }
    }
}
