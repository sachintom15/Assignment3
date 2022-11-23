using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class program
    {
        public void sum(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("The sum of numbers is= " + c);
        }
        public void sum(double a, double b, double d)
        {
            double c = a + b + d;
            Console.WriteLine("The sum of numbers is =" + c);
        }
    }
        class qstn2polymorphism
    {
        static void Main(string[] args)
        {
            program obj = new program();
            obj.sum(10, 2);
            obj.sum(10.2, 2.6, 1.2);




        }
    }
  
}
