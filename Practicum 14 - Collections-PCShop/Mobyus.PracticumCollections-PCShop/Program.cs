using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobyus.PracticumCollections_PCShop
{
	class Program
	{
		static void Main(string[] args)
		{
			PCShop pcShop = new PCShop();
			pcShop.PcToevoegen(new PC("DF6", "i7", 16, 500));
			pcShop.PcToevoegen(new PC("ZER6D23", "i7", 8, 1000));
			pcShop.PcToevoegen(new PC("6SDS", "i7", 32, 2000));
			pcShop.PcToevoegen(new PC("WXVC5", "i5", 12, 480));
			pcShop.PcToevoegen(new PC("YI5", "i5", 8, 256));
			pcShop.PcToevoegen(new PC("G56GT", "i5", 16, 1500));
			pcShop.PcToevoegen(new PC("SQF65", "i5", 10, 1500));
			pcShop.PcToevoegen(new PC("897DS", "i3", 8, 2500));
			pcShop.PcToevoegen(new PC("VML56DJ", "i3", 8, 500));
			pcShop.PcToevoegen(new PC("4SLK5", "i3", 16, 500));

			bool stop = false;

			Console.WriteLine("Welkom in de PC shop. Kies een van de volgende opties: ");
			do
			{
				Console.WriteLine(" 1. Overzicht winkel");
				Console.WriteLine(" 2. Overzicht - geheugen selectie (Gb)");
				Console.WriteLine(" 3. Overzicht - processor type selectie");
				Console.WriteLine(" 4. Overzicht - harde schijf selectie (Gb)");
				Console.WriteLine(" 9. Stoppen");
				string keuze = Console.ReadLine();

				switch (keuze)
				{
					case "1":
						PrintPCSelectie(pcShop.PCVoorraad);
						break;
					case "2":
						Console.Write("Geef het gewenste geheugen in: ");
						int geheugen = int.Parse(Console.ReadLine());
						PrintPCSelectie(pcShop.SelectieOpGeheugen(geheugen));
						break;
					case "3":
						Console.Write("Geef de gewenste processor in: ");
						string processor = Console.ReadLine();
						PrintPCSelectie(pcShop.SelectieOpTypeProcessor(processor));
						break;
					case "4":
						Console.Write("Geef de gewenste harde schijf: ");
						int hardeschijf = int.Parse(Console.ReadLine());
						PrintPCSelectie(pcShop.SelectieOpHardeschijf(hardeschijf));
						break;
					case "9":
						stop = true;
						break;
					default:
						Console.WriteLine("Ongeldige keuze. Druk op enter om een nieuwe keuze in te geven.");
						Console.ReadLine();
						Console.Clear();
						continue;
				}
				if (!stop)
				{
					Console.WriteLine("Geef de PC code in om deze te kopen. Blanco indien je niets wenst aan te kopen");
					string code = Console.ReadLine();
					if (!string.IsNullOrEmpty(code))
					{
						if (pcShop.KoopPC(code))
						{
							Console.WriteLine("Proficiat met de aankoop! Druk op enter om verder te gaan");
						}
						else
						{
							Console.WriteLine("Ongekende code. Druk op enter om verder te gaan");
						}
						Console.ReadLine();
					}
					Console.Clear();
				}
			} while (!stop);
		}

		public static void PrintPCSelectie(List<PC> pcSelectie)
		{
			foreach (PC pc in pcSelectie)
			{
				Console.WriteLine(pc.Omschrijving());
			}
		}
	}
}
