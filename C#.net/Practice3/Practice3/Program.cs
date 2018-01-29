using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    class Program
    {
        const int earthRadious = 6378;
        const long meanDistranceToSun = 149600000;
        const double meanOrbitalVelocity = 29.79D;
        static void Main(string[] args)
        {
            Console.WriteLine("Earth Radious: " + earthRadious);
            Console.WriteLine("Mean distrance to sun" + meanDistranceToSun);
            Console.WriteLine("Mean Orbital Velocity" + meanOrbitalVelocity);
            Console.ReadKey();
        }
    }
}
