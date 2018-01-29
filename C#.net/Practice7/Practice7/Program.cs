using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sales = 0;
            double bonus = 5000;
            string input = string.Empty;
            input = Console.ReadLine();
            bool isParsed = Int32.TryParse(input, out sales);
            if (sales > 10000)
            {
                bonus += .05 * sales;
            }
            else if (sales > 5000)
            {
                bonus += .01 * sales;
            }
            else
            {
                bonus = 0;
                Console.WriteLine("Sorry you could not achieve sales target");
            }
            Console.WriteLine("Your bonus is :"+ bonus);
            Console.ReadKey();
        }
    }
}
