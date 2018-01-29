using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12_1
{
    interface ICarnivore
    {
        bool IsHungry { get; }
        void Hunt();
        void Eat(string victim);
    }
    public class Lion : ICarnivore
    {
        private bool hungry;
        public bool IsHungry
        {
            get
            {
                return hungry;
            }
        }
        public void Hunt()
        {
            Console.WriteLine("Lion hunt");
        }
        public void Eat(string victim)
        {
            Console.WriteLine("Lion eats"+victim);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ICarnivore ObjICarnivore = new Lion();
            ObjICarnivore.Hunt();
            Console.ReadKey();
        }
    }
}
