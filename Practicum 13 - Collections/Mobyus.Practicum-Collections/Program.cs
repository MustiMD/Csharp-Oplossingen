using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mobyus.Practicum10_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuOptie = "";
            WagenPark wagenpark = new WagenPark();
            List<Garage> garages = new List<Garage>();

            do
            {
                Console.Clear();
                Console.WriteLine("*** WagenPark Beheer ***");
                Console.WriteLine("1. Voeg een wagen toe");
                Console.WriteLine("2. Geef wagenpark overzicht");
                Console.WriteLine("3. Voer expertise uit");
                Console.WriteLine("4. Voeg een garage toe");
                Console.WriteLine("5. Repareer wagen");
                Console.WriteLine("6. Stop");
                Console.WriteLine(" > ");
                menuOptie = Console.ReadLine();
                switch (menuOptie)
                {
                    case "1":
                        Wagen wagen = new Wagen();
                        Console.Write("Geef de nummerplaat van de wagen: ");
                        wagen.Nummerplaat = Console.ReadLine();
                        Console.Write("Geef het merk van de wagen: ");
                        wagen.Merk = Console.ReadLine();
                        if (wagenpark.SchrijfWagenIn(wagen))
                        {
                            Console.WriteLine("Wagen met nummerplaat " + wagen.Nummerplaat + " werd toegevoegd.");
                        }
                        else
                        {
                            Console.WriteLine("De wagen werd niet aan het wagenpark toegevoegd - blanco nummerplaat niet toegelaten");
                        }
                        break;
                    case "2":
                        Console.WriteLine(wagenpark.GeefOverzicht());
                        break;
                    case "3":
                        new ExpertiseBureau().VoerExpertiseUit(wagenpark.Wagens);
                        Console.WriteLine("De expertise op het wagenpark werd uitgevoerd");
                        break;
                    case "4":
                        Console.Write("Geef de naam van de garage: ");
                        string garageNaam = Console.ReadLine();
                        Console.Write("Geef het merk van de garage: ");
                        string garageMerk = Console.ReadLine();
                        garages.Add(new Garage(garageNaam, garageMerk));
                        Console.WriteLine("Garage " + garageNaam + " werd toegevoegd.");
                        break;
                    case "5":
                        Console.Write("Geef de nummerplaat in van de te repareren wagen: ");
                        string nummerplaat = Console.ReadLine();
                        Wagen terepareren = wagenpark.ZoekWagen(nummerplaat);
                        if (terepareren == null)
                        {
                            Console.WriteLine("De wagen met nummerplaat " + nummerplaat + " werd niet gevonden");
                        }
                        else
                        {
                            Garage garage = null;
                            foreach (var g in garages)
                            {
                                if (g.Merk == terepareren.Merk)
                                {
                                    garage = g;
                                }
                            }
                            if (garage == null)
                            {
                                Console.WriteLine("Er werd geen garage gevonden voor het merk " + terepareren.Merk);
                            }
                            else
                            {
                                double factuur = garage.RepareerWagen(terepareren);
                                Console.WriteLine("De wagen werd gerepareerd door garage " + garage.Naam + " Totale kost: " + factuur);
                            }
                        }
                        break;
                    case "6":
                        break;
                    default:
                        Console.WriteLine("Ongeldige menu optie");
                        break;
                }
                if (menuOptie != "6")
                {
                    Console.WriteLine("Druk op een toets om verder te gaan");
                    Console.ReadKey();
                }
            } while (menuOptie != "6");
        }
    }
}
