﻿using BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class BAL_Patient
    {
        private static readonly DAL_Patient _patient = new DAL_Patient();
        public static int InsertPatient(int id,int temp, int blood, int pulse, int breath,int weight, int height,int waist, int hip , string note)
        {
            return _patient.InsertPatient(id, temp, blood,pulse, breath,weight, height,waist,hip, note);
        }
        public static int UpdatePatient(int id, int temp, int blood, int pulse, int breath, int weight, int height, int waist, int hip, string note)
        {
            return _patient.UpdatePatient(id, temp, blood, pulse, breath, weight, height, waist, hip, note);
        }
        public static int InsertPatientNoValue(int id)
        {
            return _patient.InsertPatientNoValue(id);
        }
        public static int InsertPatientStatus(int id, string complain, string issue)
        {
            return _patient.InsertPatientStatus(id,complain,issue);
        }
        public static int UpdatePatientStatus(int id, string complain, string issue)
        {
            return _patient.UpdatePatientStatus(id, complain, issue);
        }
    }
}