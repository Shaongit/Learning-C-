using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_12
{
    class Program
    {
        public class Lion
        {
            private string name;
            public Lion()
            {
                this.name = "Lion name not found!";
            }
            public Lion(string newLionName)
            {
                this.name = newLionName;
            }
            public void LionName()
            {
                Console.WriteLine(name);
            }
        }
        static void Main(string[] args)
        {
            Lion babyLion = new Lion("Leo is a baby lion");
            babyLion.LionName();
            Lion noLionName = new Lion();
            noLionName.LionName();
            Console.ReadKey();
        }
    }
}
