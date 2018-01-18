using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practicum_2___Oefening_2___Variabelen
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.Write("Gelieve een karakter in te geven om zijn ASCII waarde te kennen: ");
            char karakter = Char.Parse(Console.ReadLine());
            int ascii = (int)karakter;
            Console.WriteLine("De ASCII waarde van " + karakter + " is: " + ascii);
            Console.ReadLine();
		}
	}
}
