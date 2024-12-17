using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concepts
{
    public class MethodOverriding : Employee
    {
        public override void Greeting()
        {
            Console.WriteLine("Derived Class");
        }
    }
}
