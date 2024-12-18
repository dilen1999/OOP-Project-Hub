using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concepts
{
    public class Employee : EmployeeSalary
    {
        public int Experience { get; set; }

        public void CalculatePayment()
        {
            int salary = Experience * 2000;
            Console.WriteLine(salary.ToString());
        }
        
        public virtual void Greeting()
        {
            Console.WriteLine("Base Class");
        }
    }
}
