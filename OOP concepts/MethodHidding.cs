using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concepts
{
    public class MethodHidding : Employee
    {
        public new void Greeting() 
        {
            Console.WriteLine("Method Hidding");
        }
    }
}
