using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice9_9
{
    class Address
    {
        public int number;
        public string name;
        public string city;
    }
    class Zoo
    {
        private int streetNumber = 123;
        private string streetName = "High street";
        private string cityName = "Dhaka";
        public void GetAddress(Address zooAddress)
        {
            zooAddress.number = streetNumber;
            zooAddress.name = streetName;
            zooAddress.city = cityName;
        }
    }
        
        
    class Program
    {
        static void Main(string[] args)
        {
            Zoo localZoo = new Zoo();
            Address zooLocation = new Address();
            zooLocation.city = "Chittagong";
            localZoo.GetAddress(zooLocation);
            Console.WriteLine(zooLocation.city);
            Console.ReadKey();
        }
    }
}
