using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10
{
    class Program
    {
       
    

        static void Main(string[] args)
        {
            int n = 50;
            int sum = 0;
            for (int i = 1; int i <= n; i++)
            {
                Console.Writeline("Sum of {0} to {1} = {2}", 1, i, sum = sum + i);
            }
            Console.ReadKey();
        }
    }
}
