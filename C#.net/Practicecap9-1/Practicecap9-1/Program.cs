using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicecap9_1
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public int YearOfExperience { get; set; }
        public double GetSalary()
        {
            if (this.YearOfExperience > 5)
                return 70000;
            else
                return 40000;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee();
            objEmployee.FirstName = "Mahedee";
            objEmployee.LasttName = "Hasan";
            objEmployee.YearOfExperience = 7;
            Console.WriteLine("Salary :"+objEmployee.GetSalary());
            Console.ReadKey();
        }
    }
}
