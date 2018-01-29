using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10_3
{
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("Constructing animal");
        }
    }
    public class Elephant : Animal
    {
        public Elephant()
        {
            Console.WriteLine("Constructing Elephant");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Elephant e = new Elephant();
            Console.ReadKey();
        }
    }
}
