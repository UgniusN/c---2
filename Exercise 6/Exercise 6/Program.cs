using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            String user;
            String pass;
            bool busena = false;
            for (int i=0; i<3; i++)
            {
                Console.WriteLine("Iveskite prisijungimo varda: ");
                user = Console.ReadLine();
                Console.WriteLine("Iveskite prisijungimo slaptazodi: ");
                pass = Console.ReadLine();
                if (user == "rimas" && pass == "kietas")
                {
                    busena = true;
                    break;
                }
                else
                {
                    busena = false;
                    Console.WriteLine("Neteisingas slaptazodis arba prisijungimo vardas");
                }
            }
            if (busena == true)
            {
                Console.WriteLine("Sekmingai prisijungta");
            }
            else
            {
                Console.WriteLine("Virsijote prisijungimo limita");
            }
            Console.ReadLine();
        }
    }
}
