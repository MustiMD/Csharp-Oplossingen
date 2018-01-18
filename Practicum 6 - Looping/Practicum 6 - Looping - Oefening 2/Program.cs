using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practicum_6___Looping___Oefening_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gelieve het aantal gewenste lijnen in te geven: ");
            int lijnen = int.Parse(Console.ReadLine());

            Console.Write("Gelieve het aantal kolommen in te geven: ");
            int kolommen = int.Parse(Console.ReadLine());

            for (int i = 0; i < lijnen; i++)
            {
                for (int j = 0; j < kolommen; j++)
                {
                    if (i%2 == 0)
                    {
                        Console.Write((kolommen - 1 - j) + " ");
                    }
                    else
                    {
                        Console.Write(j + " ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
