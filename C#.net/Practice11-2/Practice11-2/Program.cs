using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1,2,3,4,5,6,-1,-2,-3};
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
