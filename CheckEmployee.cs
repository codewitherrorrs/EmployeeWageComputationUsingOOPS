using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationUsingOOPS
{
    public class CheckEmployee
    {
        public void checkEmployee()
        {
            int isFullTime = 1;
            Random random = new Random();
            int empCheck = random.Next(2);

            if (empCheck == isFullTime)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
