using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    enum blueChipTeam
    {
        Azad,
        Mahedee,
        Sarwar,
        Jamil
    }
    enum Planets
    {
        Mercury = 2437;
        Venus = 6095;
        Earth = 6378
    }
    class Program
    {
        static void Main(string[] args)
        {
            blueChipTeam aMember = blueChipTeam.Mahedee;
            blueChipTeam bMember = blueChipTeam.Jamil;
            Planets aPlanet = Planets.Earth;
            Console.WriteLine(aMember);
            Console.WriteLine(bMember);
            Console.WriteLine(aPlanet);
            Console.WriteLine(Convert.ToInt32(aPlanet));
            Console.ReadKey();
        }
    }
}
