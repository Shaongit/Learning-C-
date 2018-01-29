using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 50;
            double b = 5;
            double output = Sum(a,b);
            Console.WriteLine(output);
            output = Sub(a,b);
            Console.WriteLine(output);
            output = Mul(a,b);
            Console.WriteLine(output);
            output = Div(a,b);
            Console.WriteLine(output);
            Console.ReadKey();
        }

        private static double Div(double a, double b)
        {
           return a/b;
        }

        private static double Mul(double a, double b)
        {
           return a*b;
        }

        private static double Sub(double a, double b)
        {
            return a - b;
        }

        private static double Sum(double a, double b)
        {
           return a+b;
        }
    }
}
