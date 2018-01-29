using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_11
{
    public class Lion
    {
        private string name;
        public Lion()
        {
            Console.WriteLine("Constructing lion");
        }
        public Lion(string newLionName)
        {
            this.name = newLionName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lion babyLion = new Lion();
            Console.WriteLine("Made a new lion object");
            Console.ReadKey();
        }
    }
}
