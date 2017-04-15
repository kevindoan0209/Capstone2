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
            return _appointment.InsertNewAppointment(beginDate,endDate,reason,complain, patientId, doctorId);
        }
    }
}
