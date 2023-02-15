using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationUsingOOPS
{
    public class CalculatDailyWage
    {
        public void calculateDailywage()
        {

            int isFullTime = 1;
            int empRatePerHrs = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(2);

            if (empCheck == isFullTime)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * empRatePerHrs;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
