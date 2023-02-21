using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationUsingOOPS
{
    public class CompanyEmployeeWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public CompanyEmployeeWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void setTotal(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string tostring()
        {
            return "Total Emp Wage for Company : " + this.company + " is " + this.totalEmpWage;
        }
    }
}
