using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_4
{
    public class MyCompany : CompanyInfo
    {
        base.CompanyName = "Leads Corporation ltd.";
        base.NumberOfArchitect = 5;
        base.NumberOfSoftwareEngineers = 10;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyCompany objMyCompany = new MyCompany();
            Console.WriteLine(objMyCompany.CompanyName);
           
        }
    }
}
