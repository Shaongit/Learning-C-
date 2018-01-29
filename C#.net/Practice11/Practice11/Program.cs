using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int yearOfExperience { get; set; }
        public double GetSalary()
        {
            if (this.yearOfExperience > 5)
                return 7000;
            else
                return 4000; 
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee();
            objEmployee.firstName = "Mahedee";
            objEmployee.lastName = "Hasan";
            objEmployee.yearOfExperience = 7;
            Console.WriteLine("Salary: "+ objEmployee.GetSalary());
            Console.ReadKey();
        }
    }
}
