using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BussinessLogicLayer
{
    public class BLL_Precription
    {
        private static readonly DAL_Precription _precription = new DAL_Precription();
        public static int InsertNewPrecription(string note, DateTime date, int money, int patientId, int doctorId)
        {
            return _precription.InsertNewPrecription(note, date, money, patientId, doctorId);
        }
        public static int UpdatePrecription(int precriptionId, string note, DateTime date, int money, int patientId, int doctorId)
        {
            return _precription.UpdatePrecription(precriptionId,note,date,money,patientId,doctorId);
        }

        public static int InsertPrecriptionMedicine(int precriptionId, int medicineId, int quantity, int discount, string note, int amount)
        {
            return _precription.InsertPrecriptionMedicine(precriptionId, medicineId, quantity, discount, note, amount);
        }
        public static int UpdatePrecriptionMedicine(int precriptionId, int medicineId, int quantity, int discount, string note, int amount)
        {
            return _precription.UpdatePrecriptionMedicine(precriptionId, medicineId, quantity, discount, note, amount);
        }

        public static int InsertPrecriptionParaclinical(string paraclinicalId, int precriptionId)
        {
            return _precription.InsertPrecriptionParaclinical(paraclinicalId, precriptionId);
        }
        public static int UpdatePrecriptionParaclinical(string paraclinicalId, int precriptionId)
        {
            return _precription.UpdatePrecriptionParaclinical(paraclinicalId, precriptionId);
        }

        public static int InsertPrecriptionDisease(string diseaseId, int precriptionId, string note)
        {
            return _precription.InsertPrecriptionDisease(diseaseId, precriptionId, note);
        }
        public static int UpdatePrecriptionDisease(string diseaseId, int precriptionId, string note)
        {
            return _precription.UpdatePrecriptionDisease(diseaseId, precriptionId, note);
        }
    }
}
