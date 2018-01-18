using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobyus.Practicum_Klassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** GSM Box - initialisatie ***");
            Console.WriteLine("Gelieve de gegevens in te geven van de 2 toe te voegen SIM kaarten.");
            Console.WriteLine();

            GsmBox gsmBox = new GsmBox();

            Console.WriteLine(" SIM 1");
            Console.Write("   - Code: ");
            gsmBox.SimKaart1.Code = Console.ReadLine();
            Console.Write("   - GSM nummer: ");
            gsmBox.SimKaart1.GsmNummer = Console.ReadLine();
            Console.WriteLine(gsmBox.SimKaart1.Code + " werd toegevoegd aan de GSM Box");
            Console.WriteLine();
            
            Console.WriteLine(" SIM 2");
            Console.Write("   - Code: ");
            gsmBox.SimKaart2.Code = Console.ReadLine();
            Console.Write("   - GSM nummer: ");
            gsmBox.SimKaart2.GsmNummer = Console.ReadLine();
            Console.WriteLine(gsmBox.SimKaart2.Code + " werd toegevoegd aan de GSM Box");
            Console.WriteLine();

            Console.WriteLine("Druk op enter om de GSM Box te gebruiken");
            Console.ReadLine();
            Console.Clear();

            string optie = "";
            do
            {
                Console.WriteLine("*** GSM Box - menu ***");
                Console.WriteLine("1. Gegevens van SIM kaarten opvragen");
                Console.WriteLine("2. Bellen met SIM kaart");
                Console.WriteLine("3. Afsluiten");
                optie = Console.ReadLine();
                Console.WriteLine();
                switch (optie)
                {
                    case "1":
                        Console.WriteLine("SIM 1");
                        Console.WriteLine(" - Code                 : " + gsmBox.SimKaart1.Code);
                        Console.WriteLine(" - GSM nummer           : " + gsmBox.SimKaart1.GsmNummer);
                        Console.WriteLine(" - Installatiedatum     : " + gsmBox.SimKaart1.CreatieDatum);
                        Console.WriteLine(" - Datum laatste oproep : " + gsmBox.SimKaart1.DatumLaatsteOproep);
                        Console.WriteLine(" - Aantal oproepen      : " + gsmBox.SimKaart1.AantalOproepen);
                        Console.WriteLine();

                        Console.WriteLine("SIM 2");
                        Console.WriteLine(" - Code                 : " + gsmBox.SimKaart2.Code);
                        Console.WriteLine(" - GSM nummer           : " + gsmBox.SimKaart2.GsmNummer);
                        Console.WriteLine(" - Installatiedatum     : " + gsmBox.SimKaart2.CreatieDatum);
                        Console.WriteLine(" - Datum laatste oproep : " + gsmBox.SimKaart2.DatumLaatsteOproep);
                        Console.WriteLine(" - Aantal oproepen      : " + gsmBox.SimKaart2.AantalOproepen);
                        Console.WriteLine();

                        break;
                    case "2":
                        Console.Write("Met welke SIM kaart wil je bellen (geef de correcte code in): ");
                        string code = Console.ReadLine();
                        if (gsmBox.SimKaart1.Code == code)
                        {
                            gsmBox.SimKaart1.DatumLaatsteOproep = DateTime.Now;
                            Console.WriteLine("De oproep met SIM " + gsmBox.SimKaart1.Code + " is tot stand gebracht");
                            Console.WriteLine();
                        }
                        else if (gsmBox.SimKaart2.Code == code)
                        {
                            gsmBox.SimKaart2.DatumLaatsteOproep = DateTime.Now;
                            Console.WriteLine("De oproep met SIM " + gsmBox.SimKaart2.Code + " is tot stand gebracht");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Code SIM kaart niet gekend");
                            Console.WriteLine();
                        }
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Ongeldige optie");
                        break;
                }
                if (optie != "3")
                {
                    Console.WriteLine("Druk op enter om verder te gaan");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (optie != "3");
        }
    }
}
