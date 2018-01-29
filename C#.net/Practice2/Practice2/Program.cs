using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            String str1 = "Welcome to Mahedee.Net";
            String str2 = "\"Hello World\"";
            String str3 = "Trainee,\nWelcome to Mahedee.net once again.";
            String str4 = @"\t this is the varbatim sign\n";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            String sample = "c:\\My Documents\\sample.txt";
            String sample2 = @"c:\\My Documents\sample.txt";
            String sample3 = @"""";
            String sample4 = @"""Hi";
            String sample5 = @"""Hi""";
            Console.WriteLine(sample);
            Console.WriteLine(sample2);
            Console.WriteLine(sample3);
            Console.WriteLine(sample4);
            Console.WriteLine(sample5);
            Console.WriteLine("\uFEFF");
            Console.WriteLine("\u0041");
            Console.ReadKey();
        }
    }
}
