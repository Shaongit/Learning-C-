using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    class Program
    {
        static void Main(string[] args)
        {
            int aValue = 5;
            if (++aValue == 6)
            {
                Console.WriteLine("Increments the value before the expression is evaluated");
            }
            if (aValue++ == 6)
            {
                Console.WriteLine("Increments the value after the expression is evaluted.");
            }
            Console.ReadKey();
        }
    }
}
