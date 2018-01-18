using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practicum_2___Variabelen
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
            string design = "";

            Console.WriteLine("Gelieve een design karakter te kiezen (vb *, #, //...)");
            design = Console.ReadLine();

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

			Console.WriteLine(design + design + design);
			Console.WriteLine(design + "\tVoornaam\t: " + voorNaam);
            Console.WriteLine(design + "\tFamilieNaam\t: " + familieNaam);
            Console.WriteLine(design + "\tAdres\t\t: " + adres);
            Console.WriteLine(design + "\tPostcode\t: " + postCode);
            Console.WriteLine(design + "\tPlaats\t\t: " + plaats);
            Console.WriteLine(design + design + design);
			Console.WriteLine();
			Console.ReadLine();
		}
	}
}
