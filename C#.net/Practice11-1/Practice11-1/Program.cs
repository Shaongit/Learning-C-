using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 4,5,6,1,2,3,-2,-1,0};
            foreach (int i in number)
            {
                Console.Write(i);
            }
            Console.ReadKey();

        }
    }
}
