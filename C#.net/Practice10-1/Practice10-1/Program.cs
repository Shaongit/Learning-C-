using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10_1
{
    public class Employee
    {
        private double salary;
        private double taxRate = .05;
        public string name { get; set; }
        public double yearOfExp { get; set; }
        public double yearlyMedicalAllowance { get; private set; }
        public Employee()
        {
            this.yearlyMedicalAllowance = 30000;
        }
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value > 20000)
                    salary = value - value * taxRate;
                else
                    salary = value;
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee();
            objEmployee.name = "Mahedee Hasan";
            objEmployee.yearOfExp = 7;
            objEmployee.Salary = 18000;
            Console.WriteLine(objEmployee.name);
            Console.WriteLine("Salary: "+objEmployee.Salary);
            Console.WriteLine("Yearly Medical Allowance: "+objEmployee.yearlyMedicalAllowance);
            Console.ReadKey();
        }
    }
}
