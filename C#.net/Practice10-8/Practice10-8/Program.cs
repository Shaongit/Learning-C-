using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10_8
{
    public abstract class Animal
    {
        public virtual void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
        public abstract void Eat();
    }
    public class Mouse : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eat cheese");
        }
        public override void Sleep()
        {
            Console.WriteLine("Mouse sleeping");
        }
    }
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eat meat");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mouse objMouse = new Mouse();
            objMouse.Eat();
            objMouse.Sleep();
            Dog objDog = new Dog();
            objDog.Eat();
            objDog.Sleep();
            Console.ReadKey();
        }
    }
}
