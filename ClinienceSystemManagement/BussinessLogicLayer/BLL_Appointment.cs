using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BussinessLogicLayer
{
    public class BLL_Appointment
    {
        private static readonly DAL_Appointment _appointment = new DAL_Appointment();
        public static int InsertNewAppointment(DateTime beginDate, DateTime endDate, string reason, string complain, int patientId, int doctorId)
        {
            return _appointment.InsertNewAppointment(beginDate, endDate, reason, complain, patientId, doctorId);
        }
        public static int DeleteAppointment(int patientId)
        {
            return _appointment.DeleteAppointment(patientId);
        }
        public static int GetLastIdAppointment()
        {
            return _appointment.GetLastIdAppointment();
        }
        public static string GetNameDoctor(int doctorId)
        {
            return _appointment.GetNameDoctor(doctorId);
        }
        public static int UpdateAppointment(int id, string reason, string complain)
        {
            return _appointment.UpdateAppointment(id, reason, complain);
        }
    }
}
