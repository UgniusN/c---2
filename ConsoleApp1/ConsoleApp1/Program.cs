﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float skaiciusFloat = 1f / 3;
            double skaiciusDouble = 1d / 3;

            if ( skaiciusFloat == skaiciusDouble)
            {
                Console.WriteLine("skaiciusFloat {0} YRA skaiciusDouble {1}", skaiciusFloat, skaiciusDouble);
            }
            else
            {
                Console.WriteLine("skaiciusFloat {0} NERA lygus skaiciusDouble {1}", skaiciusFloat, skaiciusDouble);
            }
            Console.ReadLine();
        }
    }
}
