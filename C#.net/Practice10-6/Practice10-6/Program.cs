using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10_6
{
    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eat something");
        }
    }
    public class Cat : Animal
    {
        public void StalkPrey() { }
        public override void Eat()
        {
            //base.Eat();
            Console.WriteLine("Eat small animals");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat objCat = new Cat();
            objCat.Eat();
            Console.ReadKey();

        }
    }
}
