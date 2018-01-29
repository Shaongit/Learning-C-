using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_17
{
    class Lion
    {
        static Lion()
        {
            //class specific intialization
        }
    }
    class RandomNumberGenerator
    {
        private static Random randomNumber;
        public static string AutorName { get; set; }
        public RandomNumberGenerator(string msg)
        {
            Console.WriteLine(msg);
        }
        static RandomNumberGenerator()
        {
            AutorName = "Mahedee Hasan";
            randomNumber = new Random();
        }
        public int Next()
        {
            return randomNumber.Next();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RandomNumberGenerator randomNumber = new RandomNumberGenerator("Generate 10 random number");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(randomNumber.Next());
            }
            Console.WriteLine("Author name:"+RandomNumberGenerator.AutorName);
            Console.ReadKey();
        }
    }
}
