using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    class Program
    {
        enum CapitalMarketTeam
        {
            Faizur,
            Sinthi,
            Sajmim,
            Mahedee
        }
        static void Main(string[] args)
        {
            CapitalMarketTeam aMember = CapitalMarketTeam.Faizur;
            switch (aMember)
            {
                case CapitalMarketTeam.Faizur:
                    Console.WriteLine("Faizur Rahman, Manager of capital market team.");
                    break;
                case CapitalMarketTeam.Mahedee:
                    Console.WriteLine("Mahedee Hasan, Seniour software architect");
                    break;
                case CapitalMarketTeam.Sinthi:
                    Console.WriteLine("Jafrin Islam, Seniour software engineer");
                    break;
                case CapitalMarketTeam.Sajmim:
                    Console.WriteLine("Sajmim Ahamed, Software engineer");
                    break;
                default:
                    Console.WriteLine("Capital market team consists of Bluechip, Mbank, Capita team");
                    break;
            }
            Console.ReadKey();
        }
    }
}
