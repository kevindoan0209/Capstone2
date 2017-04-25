﻿using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class BLL_Clinience
    {
        private static readonly DAL_Clinience _clinience= new DAL_Clinience();
        public static int UpdateClinience(String name, String tel, String email, String address, String fax , int cost, int Id)
        {
            return _clinience.UpdateClinience(name,tel,email,address,fax,cost,Id);
        }
        public static int UpdateClinienceCost(int Id, int cost)
        {
            return _clinience.UpdateClinienceCost(Id, cost);
        }
        public static int GetCost()
        {
            return _clinience.GetCost();
        }
        public static int GetAmountByDay(DateTime date)
        {
            return _clinience.GetAmountByDay(date);
        }
        public static int GetAmountByMonth(DateTime date)
        {
            return _clinience.GetAmountByMonth(date);
        }
        public static int GetAmountByYear(DateTime date)
        {
            return _clinience.GetAmountByYear(date);
        }
        public static int GetAmountByALL()
        {
            return _clinience.GetAmountByALL();
        }
        public static int GetAmountByOption(DateTime beginDate, DateTime endDate)
        {
            return _clinience.GetAmountByOption(beginDate, endDate);
        }
    }
}
