using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite rutulio diametrą: ");
            String a = Console.ReadLine();
            double b = Convert.ToDouble(a);
            double plotas = b/2 * 4 * Math.PI;
            double turis = 4 / 3 * Math.PI * Math.Pow((b / 2),3);
            Console.WriteLine("Rutulio plotas: {0}", plotas);
            Console.WriteLine("Rutulio turis: {0}", turis);
            Console.Read();
        }
    }
}
