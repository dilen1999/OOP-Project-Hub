using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------Inheritance--------------------");
            PermanantEmployee employee = new PermanantEmployee();
            employee.Experience = 4;
            employee.CalculatePayment();

            Console.WriteLine("-------------------Method Overloading--------------------");
            MethodOverLoading methodOverLoading = new MethodOverLoading();
            Console.WriteLine("Addition of 29, 49: " + methodOverLoading.Add(29, 49));
            Console.WriteLine("Addition of 10, 20, 30: " + methodOverLoading.Add(10, 20, 30));
            Console.WriteLine("Addition of 10.2, 20.5, 2: " + methodOverLoading.Add(10.2, 20.5, 2));
            Console.WriteLine("Addition of 10.2, 55.2, 29: " + methodOverLoading.Add(10.2, 55.2, 29));

            Console.WriteLine("-------------------Method Overriding--------------------");
            Employee objderived = new MethodOverriding();
            objderived.Greeting();

            Console.WriteLine("-------------------Method Hiding--------------------");
            Employee objHidding = new MethodHidding();
            objHidding.Greeting();
            Console.ReadLine();
        }
    }
}
