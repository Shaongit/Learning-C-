using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10_5
{
    public class Animal
    {
        public Animal() { }
        public void Sleep() { }
        public bool IsHungry = true;
        public virtual void Eat()
        {
            Console.WriteLine("Eat something");
        }

    }
    public class Elephant : Animal
    {
        public int carryCapacity;
        public override void Eat()
        {
            Console.WriteLine("Eat grass");
        }

    }
    public class Mouse : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eat cheese");
        }
    }
    public class Cat : Animal
    {
        public void StalkPrey() { }
        public override void Eat()
        {
            Console.WriteLine("Eat mouse");
        }
    }
    public class WildLife
    {
        public WildLife()
        {
            Elephant objEle = new Elephant();
            Mouse objMouse = new Mouse();
            Cat objCat = new Cat();
            FeedingTime(objEle);
            FeedingTime(objMouse);
            FeedingTime(objCat);
        }

        private void FeedingTime(Animal objAnimal)
        {
            if (objAnimal.IsHungry)
            {
                objAnimal.Eat();
            }
        }
    }
   

    
    class Program
    {
        static void Main(string[] args)
        {
            WildLife objWildLife = new WildLife();
            Console.ReadKey();
        }
    }
}
