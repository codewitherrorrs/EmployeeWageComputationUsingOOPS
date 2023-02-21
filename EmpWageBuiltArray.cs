using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationUsingOOPS
{
    public class EmpWageBuiltArray : icompute
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;

        private int numOfCompany = 0;
        private CompanyEmployeeWage[] companyEmpWageArray;

        public EmpWageBuiltArray()
        {
            this.companyEmpWageArray = new CompanyEmployeeWage[5];
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[numOfCompany] = new CompanyEmployeeWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }

        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                int totalWage = this.computeEmpWage(this.companyEmpWageArray[i]);
                companyEmpWageArray[i].setTotal(totalWage);
                Console.WriteLine(this.companyEmpWageArray[i].tostring());
            }
        }

        private int computeEmpWage(CompanyEmployeeWage companyEmployeeWage)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorking = 0;

            while (totalEmpHrs <= companyEmployeeWage.maxHoursPerMonth && totalWorking <= companyEmployeeWage.numOfWorkingDays)
            {
                totalWorking++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case isFullTime:
                        empHrs = 8;
                        break;
                    case isPartTime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day# : " + totalWorking + " Emp Hrs : " + empHrs);

            }
            return totalEmpHrs * companyEmployeeWage.empRatePerHour;

        }
    }
}
