using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12_2
{
    interface ICarnivor
    {
        bool IsHungry { get; }
        Animal Hunt();
        void Eat(Animal victim);
    }

    public abstract class Animal
    {
        public abstract void Sleep();
    }
    public class Antelope : Animal
    {
        public override void Sleep()
        {
            
        }
    }
    public class Lion : Animal, ICarnivor
    {
        private bool hungry;
        public Lion()
        {
            hungry = true;
        }
        public bool IsHungry
        {
            get
            {
                return hungry;
            }
        }

        public void Eat(Animal prey)
        {
            Console.WriteLine("Lion is no longer hungry");
        }

        public override void Sleep()
        {
            //Sleeping
        }
        public Animal Hunt()
        {
            return new Antelope();
        }
        public void JoinPride()
        {
            //Join with a pride of other lions
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lion aLion = new Lion();
            Antelope a = new Antelope();
            if (aLion.IsHungry)
            {
                Animal victim = aLion.Hunt();
                if (victim != null)
                {
                    aLion.Eat(victim);
                }
            }
            aLion.JoinPride();
            aLion.Sleep();
            Console.ReadKey();
        }
    }
}
