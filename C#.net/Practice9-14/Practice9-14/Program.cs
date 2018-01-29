using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_14
{
    class Lion
    {
        private string name;
        private int age;
        public Lion(string theName, int theAge)
        {
            name = theName;
            age = theAge;
        }
        public Lion(string theName)
        {
            name = theName;
        }
        public Lion(int theAge)
        {
            age = theAge;
        }
        public void DisplayLionInfo()
        {
            Console.WriteLine("Lion name: "+name+"\nLion age:"+age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lion adoptedLion = new Lion("Leo", 3);
            adoptedLion.DisplayLionInfo();
            Lion otherAdoptedLion = new Lion("Fang");
            otherAdoptedLion.DisplayLionInfo();
            Lion newbornLion = new Lion(1);
            newbornLion.DisplayLionInfo();
            Console.ReadKey();
        }
    }
}
