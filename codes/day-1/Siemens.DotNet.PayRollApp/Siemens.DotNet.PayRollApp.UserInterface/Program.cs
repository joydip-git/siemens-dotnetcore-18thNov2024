using Siemens.DotNet.PayRollApp.Entities;


namespace Siemens.DotNet.PayRollApp.UserInterface
{
    class Program
    {
        static void Main()
        {
            Developer d = new Developer(1, "sunil", 1400, 2000, 3000, 4000);
            Hr hr = new Hr(2, "anil", 1200, 2000, 3000, 4000);
            Developer joydipDeveloper = new Developer(1, "sunil", 1400, 2000, 3000, 4000);

            //Employee[] employees = new Employee[] { d, hr };
            //Employee[] employees = new Employee[3];

            if (d.Equals(joydipDeveloper))
            {
                Console.WriteLine("same");
            }else
                Console.WriteLine("not same");
            

            //Developer d1 = (Developer) new Employee();
            //d1.IncentivePayment
            //PrintSalary(d);
            //PrintSalary(hr);
        }
        static void PrintSalary(Employee e)
        {
            e.CalculateSalary();
            Console.WriteLine(e.TotalPayment);
        }
        //static void PrintSalary(Developer d)
        //{
        //    d.CalculateDeveloperSalary();
        //    Console.WriteLine(d.TotalPayment);
        //}
        //static void PrintSalary(Hr h)
        //{
        //    h.CalculateHrSalary();
        //    Console.WriteLine(h.TotalPayment);
        //}
    }
}


