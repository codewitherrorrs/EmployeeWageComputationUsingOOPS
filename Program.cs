namespace EmployeeWageComputationUsingOOPS
{
    public class EmployeeWage
    {
        public static void Main(string[] args)
        {
            EmployeeWageMultiple e1= new EmployeeWageMultiple();
            int a = e1.EmployeeWage("BridgeLabz",20,20,100);
            Console.WriteLine("First Company :"+a);

            EmployeeWageMultiple e2 = new EmployeeWageMultiple();
            int b = e2.EmployeeWage("AkadBakad", 20, 20, 100);
            Console.WriteLine("Second Company : "+b);

        }
    }
}