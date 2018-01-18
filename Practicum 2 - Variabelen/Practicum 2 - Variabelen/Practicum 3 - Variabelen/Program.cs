using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practicum_3___Variabelen
{
	class Program
	{
		static void Main(string[] args)
		{
			string voorNaam = "";
			string familieNaam = "";
			string adres = "";
			string postCode = "";
			string plaats = "";

			Console.WriteLine("Gelieve je coordinaten in te geven:");
			Console.Write("Voornaam: ");
			voorNaam = Console.ReadLine();
			Console.Write("Familienaam: ");
			familieNaam = Console.ReadLine();
			Console.Write("Adres: ");
			adres = Console.ReadLine();
			Console.Write("Postcode: ");
			postCode = Console.ReadLine();
			Console.Write("Plaats: ");
			plaats = Console.ReadLine();
			Console.WriteLine("");

			Console.WriteLine("|-------------------------------------------------------------------|");
			Console.WriteLine("|\tVoornaam\t: " + voorNaam);
			Console.WriteLine("|\tFamilieNaam\t: " + familieNaam);
			Console.WriteLine("|\tAdres\t\t: " + adres);
			Console.WriteLine("|\tPostcode\t: " + postCode);
			Console.WriteLine("|\tPlaats\t\t: " + plaats);
			Console.WriteLine("|-------------------------------------------------------------------|");
			Console.WriteLine();
			Console.ReadLine();
		}
	}
}
