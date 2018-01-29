using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_6
{
    class Lion
    {
        private int weight;
        public bool IsNormalWeight()
        {
            if (weight < 50 || weight > 250)
            {
                return false;
            }
            return true;
        }
        public void Eat() { }
        public void SetWeight(int weight)
        {
            this.weight = weight;
        }
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
            bigLion.SetWeight(80);
            if (bigLion.IsNormalWeight() == false)
            {
                Console.WriteLine("Lion weight is abnormal");
            }
            Console.WriteLine("Lion weight is normal");
            Console.ReadKey();
        }
    }
}
