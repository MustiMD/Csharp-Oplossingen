using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum8_Functies
{
    class Program
    {
        static void Main(string[] args)
        {
            string opnieuw = string.Empty;
            do
            {
                Blackjack game = new Blackjack();
                double inzet = 0;
                bool inzetOk = false;
                Console.Clear();
                Console.WriteLine("********************");
                Console.WriteLine("***   BLACKJACK  ***");
                Console.WriteLine("********************");
                do
                {
                    Console.Write("Geef je inzet in: ");
                    inzet = double.Parse(Console.ReadLine());
                    inzetOk = game.BepaalInzet(inzet);
                    if (!inzetOk)
                    {
                        Console.WriteLine("Gelieve een positief getal in te geven");
                    }
                } while (!inzetOk);

                Console.WriteLine();
                do
                {
                    Console.WriteLine(Environment.NewLine + "Trek een kaart - druk op enter");
                    Console.ReadLine();
                    Console.WriteLine("===============================================");
                    Console.WriteLine(game.TrekKaart());
                    Console.WriteLine(game.GeefOverzicht());
                    Console.WriteLine("===============================================");
                } while (game.SpelStatus == "1");

                Console.Write(Environment.NewLine + "Opnieuw (j/n)?: ");
                opnieuw = Console.ReadLine();
            } while (opnieuw.ToUpper() == "J");

        }
    }
}
