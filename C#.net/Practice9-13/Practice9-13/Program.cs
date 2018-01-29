using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_13
{
    class Zoo
    {
        private int numberAnimals;
        public readonly decimal admissionPrice;
        public Zoo(int noOfAnimal)
        {
            this.numberAnimals = noOfAnimal;
            if (numberAnimals > 50)
            {
                admissionPrice = 25;
            }
            else
            {
                admissionPrice = 20;
            }
            
        }
        public void AdmissionPrice()
        {
            Console.WriteLine("Admission cost is :"+admissionPrice);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo(40);
            zoo.AdmissionPrice();
            Console.ReadKey();
        }
    }
}
