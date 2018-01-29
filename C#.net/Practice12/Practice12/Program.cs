using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNamespace.Test
{
    public class Lion
    {
        public int age;
        private int weight;
    }
    class ClassMain
    {
        static void Main(string[] args)
        {
            Lion zooLion = new Lion();
            zooLion.age = 7;
            //zooLion.weight = 200;
        }
    }
}
