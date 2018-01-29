using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_5
{
    class Lion
    {
        private int weight = 110;
        public bool IsNormalWeight()
        {
            if (weight < 100 || weight > 250)
            {
                return false;
            }
            return true;

        }
        public void Eat() { }
        public int GetWeight()
        {
            return weight;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lion bigLion = new Lion();
            if (bigLion.IsNormalWeight() == false)
            {
                Console.WriteLine("Lion weight is abnormal");
                Console.ReadKey();
            }
            Console.WriteLine("Lion weight is normal");
            Console.ReadKey();
        }
    }
}
