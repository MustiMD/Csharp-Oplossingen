using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practicum_6___Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gelieve een reeks positieve gehele getallen in te geven. Negatief om te stoppen.");

            int input = 0;
            double maximum = 0;
            double gemiddelde = 0;
            double aantal = 0;
            string opnieuw = "n";

            do
            {
                input = 0;
                maximum = 0;
                gemiddelde = 0;
                aantal = 0;
                do
                {
                    Console.Write(aantal + 1 + "> ");
                    input = int.Parse(Console.ReadLine());
                    if (input > maximum)
                    {
                        maximum = input;
                    }
                    if (input >= 0)
                    {
                        gemiddelde += input;
                        aantal++;
                    }
                } while (input >= 0);

                if (aantal == 0)
                {
                    Console.WriteLine("Het gemiddelde en maximum kan niet bepaald worden, er werden geen getallen ingegeven");
                }
                else
                {
                    Console.WriteLine("Het maximum van de ingegeven reeks is: " + maximum);
                    Console.WriteLine("Het gemiddelde van de ingegeven getallen is: " + gemiddelde / aantal);
                }


                Console.Write("Opnieuw het gemiddelde en maximum bepalen? (j/n): ");
                opnieuw = Console.ReadLine();
            } while (opnieuw == "j" || opnieuw == "J");
        }
    }
}
