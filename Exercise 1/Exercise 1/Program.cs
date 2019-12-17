using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma simboli");
            char a = Console.ReadKey().KeyChar;
            Console.WriteLine("Iveskite antra simboli");
            char b = Console.ReadKey().KeyChar;
            Console.WriteLine("Iveskite trecia simboli");
            char c = Console.ReadKey().KeyChar;

            Console.WriteLine("{0} {1} {2}",c,b,a);
            Console.Read();

        }
    }
}
