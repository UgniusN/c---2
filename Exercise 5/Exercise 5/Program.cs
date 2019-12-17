using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu: ");
            String a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            Console.WriteLine("{0}",b);
            Console.WriteLine("{0}{0}", b);
            Console.WriteLine("{0}{0}{0}", b);
            Console.ReadLine();

        }
    }
}
