using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10_7
{
    public abstract class Animal
    {
        public abstract void Eat();
    }
    public class Mouse : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eat cheese");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mouse objMouse = new Mouse();
            objMouse.Eat();
            Console.ReadKey();
        }
    }
}
