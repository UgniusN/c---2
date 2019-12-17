using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite temperatura(C): ");
            String a = Console.ReadLine();
            int C = Convert.ToInt32(a);
            double K = (double)C * 274.15;
            double F = (double)C * 33.8;
            Console.WriteLine("{0} Celciju yra {1} Kelvinu",C,K);
            Console.WriteLine("{0} Celciju yra {1} Farenhaitu", C, F);
            Console.ReadLine();
        }
    }
}
