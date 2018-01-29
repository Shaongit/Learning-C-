using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicecap9_2
{
    public class CompanyInfo
    {
        public string CompanyName { get; set; }
        internal int NumberOfEmployee { get; set; }
    }
    public class CompanySelector
    {
        CompanyInfo GetCompanyInfo = new CompanyInfo();
        public CompanyInfo GetCompanyInfo()
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
