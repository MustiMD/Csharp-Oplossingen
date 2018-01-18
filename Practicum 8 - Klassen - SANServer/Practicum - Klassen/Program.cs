using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practicum_Klassen
{
	class Program
	{
		static void Main(string[] args)
		{
            SAN san = new SAN();
            bool inputOK;
            Console.WriteLine("SAN BEHEER");
            Console.WriteLine("==========");
            Console.WriteLine("Geef de nodige SAN gegevens in");
            do
            {
                inputOK = true;
                Console.Write("\nRAID ondersteuning (j/n)?: ");
                switch (Console.ReadLine())
                {
                    case "j":
                    case "J":
                        san.RaidSet = true;
                        break;
                    case "n":
                    case "N":
                        san.RaidSet = false;
                        break;
                    default:
                        inputOK = false;
                        break;
                }
            } while (!inputOK);

            // Hardisk1
            Console.WriteLine("\nGelieve de gegevens van hardisk 1 in te geven");
            Console.Write("  Model: ");
            san.Hardisk1.Model = Console.ReadLine();
            Console.Write("  Grootte (Tb): ");
            san.Hardisk1.Size = int.Parse(Console.ReadLine());

            // Hardisk2
            Console.WriteLine("\nGelieve de gegevens van hardisk 2 in te geven");
            Console.Write("  Model: ");
            san.Hardisk2.Model = Console.ReadLine();
            Console.Write("  Grootte (Tb): ");
            san.Hardisk2.Size = int.Parse(Console.ReadLine());

            Console.Clear();

            string menuInput = "";
            do
            {
                Console.WriteLine("\nKies optie uit onderstaand menu");
                Console.WriteLine("  1. Geef SAN overzicht");
                Console.WriteLine("  2. Controleer RAID");
                Console.WriteLine("  3. Stop programma");
                menuInput = Console.ReadLine();

                switch (menuInput)
                {
                    case "1":
                        Console.WriteLine("\nSAN overzicht");
                        Console.WriteLine("-------------");
                        Console.WriteLine("  Hardisk 1:");
                        Console.WriteLine("   - Model: " + san.Hardisk1.Model);
                        Console.WriteLine("   - Grootte: " + san.Hardisk1.Size);
                        Console.WriteLine("  Hardisk 2:");
                        Console.WriteLine("   - Model: " + san.Hardisk2.Model);
                        Console.WriteLine("   - Grootte: " + san.Hardisk2.Size);
                        break;
                    case "2":
                        Console.WriteLine("\nSAN - RAID controle");
                        Console.WriteLine("-------------------");
                        if (san.RaidSet)
                        {
                            if (san.Hardisk1.Size == san.Hardisk2.Size)
                            {
                                Console.WriteLine("RAID configuratie OK - Disk grootte: " + san.Hardisk1.Size);
                            }
                            else
                            {
                                if (san.Hardisk1.Size > san.Hardisk2.Size)
                                {
                                    Console.WriteLine("RAID configuratie niet optimaal - Maximale disk grootte: " + san.Hardisk2.Size);
                                }
                                else
                                {
                                    Console.WriteLine("RAID configuratie niet optimaal - Maximale disk grootte: " + san.Hardisk1.Size);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Geen RAID ondersteuning voorzien.");
                        }
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("\nMenu optie niet gekend");
                        break;
                }
                if (menuInput != "3")
                {
                    Console.WriteLine("Druk op enter om door te gaan");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (menuInput != "3");

		}
	}
}
