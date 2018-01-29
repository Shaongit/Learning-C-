using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_3
{

    public class CompanyInfo
    {
        public string CompanyName { get; set; }
        internal int NumberOfEmployee { get; set; }
        protected int NumberOfArchitect { get; set; }
        protected internal int NumberOfSoftwareEngineer { get; set; }
    }
    public class CompanySelector
    {
        public CompanyInfo GetCompanyInfo()
        {
            CompanyInfo objCompanyInfo = new CompanyInfo();
            objCompanyInfo.CompanyName = "Leadsoft Bangladesh LTD.";
            objCompanyInfo.NumberOfEmployee = 26;
            objCompanyInfo.NumberOfSoftwareEngineer = 16;
            return objCompanyInfo;
        }
        
    }
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
            Console.ReadKey();
        }
    }
}
