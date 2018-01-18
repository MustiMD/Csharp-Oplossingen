using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practicum_1___Console_applicatie___Oefening_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Gelieve je adres gegevens in te geven:");
			Console.Write("Straat\t:\t");
			string straat = Console.ReadLine();
			Console.Write("Postcode:\t");
			string postcode = Console.ReadLine();
			Console.Write("Plaats\t:\t");
			string plaats = Console.ReadLine();

            Console.WriteLine("\nJe adreskaart gegevens: ");
            Console.WriteLine("******************************************");
            Console.WriteLine("* Straat\t:" + straat);
            Console.WriteLine("* Postcode\t:" + postcode);
            Console.WriteLine("* Plaats\t:" + plaats);
            Console.WriteLine("******************************************");
            Console.ReadLine();
		}
	}
}
