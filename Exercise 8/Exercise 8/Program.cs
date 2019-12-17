using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = Console.ReadLine();
            double b = Convert.ToDouble(a);
            int c = Convert.ToInt32(b);
            byte d = Convert.ToByte(b);
            short e = Convert.ToInt16(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}
