﻿using System;

namespace Hissi
{
    class Hissi
    {
        private const int minKerros = 1;
        private const int maxKerros = 5;
        private int kerros = 1;

        public int Kerros
        {
            get
            {
                return kerros;
            }
            set
            {
                if (value < minKerros)
                {
                    Console.WriteLine("Floor is too small!");
                }
                else if (value > maxKerros)
                {
                    Console.WriteLine("Floor is too big!");
                }
                else
                {
                    kerros = value;
                }
            }
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi();
            bool result;
            do
            {      
                Console.WriteLine("Elevator is now in floor : " + hissi.Kerros);
                Console.Write("Give a new floor number (1-5) > ");
                String line = Console.ReadLine();
                int kerros;
                result = Int32.TryParse(line, out kerros);
                if (result)
                {
                    hissi.Kerros = kerros;
                }
            } while (result);

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}