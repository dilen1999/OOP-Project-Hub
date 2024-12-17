using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concepts
{
    public class MethodOverLoading
    {
        public int Add(int a, int b) 
        {
            return a + b;
        }
        public int Add(int a , int b, int c) { return a + b + c; }
        public double Add(double a, double b, int c)
        {
            return a + b + c;
        }
        public double Add(double a ,  int b, double c)
        {

        return a + b + c; }
    
    }
}
