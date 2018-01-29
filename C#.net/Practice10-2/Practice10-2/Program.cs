using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10_2
{
    public class Animal
    {
        public bool IsSleeping;
        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
        public void Eat() { }
    }
    public class Antelope : Animal
    {

    }
    public class Lion : Animal
    {
        public void stalkPrey()
        {
        }
    }
    public class Elephant : Animal
    {
        public int CarryCapacity;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Elephant e = new Elephant();
            e.Sleep();
            Console.ReadKey();
        }
    }
}
