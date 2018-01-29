using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_16
{
    class Program
    {
        public class InterestCalculator
        {
            public static double calculateInterest(int n, double p, double r)
            {
                return n * p * r;
            }
        }
        static void Main(string[] args)
        {
            double interest =InterestCalculator.calculateInterest(5,5000.0,0.10);
            Console.WriteLine("Simple interest:"+interest);
            Console.ReadLine();
        }
    }
}
