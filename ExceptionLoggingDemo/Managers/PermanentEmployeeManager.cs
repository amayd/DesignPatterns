using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExceptionLoggingDemo.Managers
{
    public class PermanentEmployeeManager : IEmployeeManagers
    {
        public decimal GetBonus()
        {
            return 100;
        }

        public decimal GetPay()
        {
            return 50;
        }
    }
}