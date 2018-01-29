using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_7
{
    class Zoo
    {
        private int streetNumber = 123;
        private string streetName = "High street";
        private string cityName = "Dhaka";
        public void GetAddress(ref int number, ref string street, ref string city)
        {
            number = streetNumber;
            street = streetName;
            city = cityName;
        }
    }
    class ClassMain
    {
        static void Main(string[] args)
        {
            Zoo localZoo = new Zoo();
            int zooStreetNumber = 0;
            string zooStreetName = null;
            string zooCity = null;
            localZoo.GetAddress(ref zooStreetNumber, ref zooStreetName, ref zooCity);
            Console.WriteLine(zooCity);
            Console.WriteLine(zooStreetNumber);
            Console.ReadKey();
        }
    }
}
