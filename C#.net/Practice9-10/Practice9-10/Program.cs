using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_10
{
    class ZooCustomer
    {
        private string name;
        private string email;
        private string favoriteAnimal;
        public void SetInfo(string webName, string webEmail, string animal)
        {
            name = webName;
            email = webEmail;
            favoriteAnimal = animal;
        }
        public void SetInfo(string webName, string webEmail)
        {
            name = webName;
            email = webEmail;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ZooCustomer objZooCustomer = new ZooCustomer();
            objZooCustomer.SetInfo("mahedee.net","mahedee.hasan@gmail.com");
            objZooCustomer.SetInfo("bdzoo.com", "bdzoo@gmail.com","tiger");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
