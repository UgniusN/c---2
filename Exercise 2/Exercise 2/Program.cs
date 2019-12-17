using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite atsuma (metrais)");
            String a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            Console.WriteLine("Iveskite laika (sekundemis)");
            String c = Console.ReadLine();
            int d = Convert.ToInt32(c);
            double greitis = (double)b / (double)d;
            Console.WriteLine(greitis);
            double greitis2 = greitis * 3.6;
            Console.WriteLine(greitis2);
            Console.Read();
        }
    }
}
