using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite isdirbtas valandas");
            String a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            int sk;

            if (b < 160 && b > 0)
            {
                sk = 160 - b;
                Console.WriteLine(sk);
            }
            else if (b > 160)
            {
                sk = b - 160;
                Console.WriteLine(sk);
            }
            else if (b == 160)
            {
                Console.WriteLine("Isdirbtas pilnas etatas");
            }
            else
            {
                Console.WriteLine("Klaida");
            }
            Console.Read();
        }
    }
}
