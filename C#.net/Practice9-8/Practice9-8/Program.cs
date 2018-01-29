using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_8
{
    class Zoo
    {
        private int streetNumber = 123;
        private string streetName = "High street";
        private string cityName = "Dhaka";
        public void GetAddress(out int number, out string name, out string city)
        {
            number = streetNumber;
            name = streetName;
            city = cityName;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Zoo localZoo = new Zoo();
            int zooStreetNumber;
            string zooStreetName;
            string zooCity;
            localZoo.GetAddress(out zooStreetNumber, out zooStreetName, out zooCity);
            Console.WriteLine(zooStreetNumber);
            Console.WriteLine(zooStreetName);
            Console.WriteLine(zooCity);
            Console.ReadKey();
        }
    }
}
