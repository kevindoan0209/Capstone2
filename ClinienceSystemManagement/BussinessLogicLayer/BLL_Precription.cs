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
        public static int UpdatePrecription(int precriptionId, string note, DateTime date, int money, string diagnose,string checkup, int patientId, int doctorId)
        {
            return _precription.UpdatePrecription(precriptionId,note,date,money, diagnose, checkup,patientId, doctorId);
        }
        public static int UpdateTreatment(string treatment, int preId)
        {
            return _precription.UpdateTreatment(treatment,preId);
        }

        public static int InsertPrecriptionMedicine(int precriptionId, int medicineId, int quantity, string note, int amount)
        {
            return _precription.InsertPrecriptionMedicine(precriptionId, medicineId, quantity, note, amount);
        }
        public static int UpdatePrecriptionMedicine(int precriptionId, int medicineId, int quantity, string note, int amount)
        {
            return _precription.UpdatePrecriptionMedicine(precriptionId, medicineId, quantity, note, amount);
        }

        public static int InsertPrecriptionParaclinical(string paraclinicalId, int precriptionId)
        {
            return _precription.InsertPrecriptionParaclinical(paraclinicalId, precriptionId);
        }
        public static int UpdatePrecriptionParaclinical(string paraclinicalId, int precriptionId)
        {
            return _precription.UpdatePrecriptionParaclinical(paraclinicalId, precriptionId);
        }

        public static int InsertPrecriptionDisease(string diseaseId, int precriptionId)
        {
            return _precription.InsertPrecriptionDisease(diseaseId, precriptionId);
        }
        public static int GetLastIdPrecription()
        {
            return _precription.GetLastIdPrecription();
        }

        public static int DeletePrecriptionMedicine(int medicineId, int precriptionId)
        {
            return _precription.DeletePrecriptionMedicine(medicineId, precriptionId);
        }

        public static int UpdatePrecriptionMoney(int money, int preId)
        {
            return _precription.UpdatePrecriptionMoney(money, preId);
        }

        public static int GetTotalMoney(int preId)
        {
            return _precription.GetTotalMoney(preId);
        }
    }
}
