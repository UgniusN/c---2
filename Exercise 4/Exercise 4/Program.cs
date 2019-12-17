using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = Console.ReadLine();
            double b = Convert.ToDouble(a);
            String c = Console.ReadLine();
            double d = Convert.ToDouble(c);
            var e = ((b % 2 == 0) == (d % 2 == 0));
            Console.WriteLine(e);
            Console.ReadLine();
        }
    }
}
