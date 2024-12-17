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
            PermanantEmployee employee = new PermanantEmployee();
            employee.Experience = 4;
            employee.CalculatePayment();
        }
    }
}
