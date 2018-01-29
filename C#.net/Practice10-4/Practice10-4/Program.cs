using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10_4
{
    public enum GenderType
    {
        Male,
        Female
    }
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("Constructing animal");
        }
        public Animal(GenderType gender)
        {
            if (gender == GenderType.Female)
            {
                Console.WriteLine("Female");
            }
            else
                Console.WriteLine("Male");
        }
    }
    public class Elephant : Animal
    {
        public Elephant(GenderType gender)
            :base(gender)
        {
            Console.WriteLine("Elephant");
        }
    }
         
    class Program
    {
        static void Main(string[] args)
        {
            Elephant e = new Elephant(GenderType.Male);
            Console.ReadKey();
        }
    }
}
