using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practicum_4___Operatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            int totaalAantalBiljetten = 0;
            int totaalAantalMuntstukken = 0;
            int aantal = 0;

            Console.Write("Gelieve het op te delen bedrag in te geven: ");
            int bedrag = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("De opsplitsing naar de verschillende biljetten en munten is: ");
            aantal = bedrag / 500;
            bedrag %= 500;
            totaalAantalBiljetten += aantal;
            Console.WriteLine("Aantal biljetten van 500 EUR: " + aantal);

            aantal = bedrag / 200;
            bedrag %= 200;
            totaalAantalBiljetten += aantal;
            Console.WriteLine("Aantal biljetten van 200 EUR: " + aantal);

            aantal = bedrag / 100;
            bedrag %= 100;
            totaalAantalBiljetten += aantal;
            Console.WriteLine("Aantal biljetten van 100 EUR: " + aantal);

            aantal = bedrag / 50;
            bedrag %= 50;
            totaalAantalBiljetten += aantal;
            Console.WriteLine("Aantal biljetten van 50  EUR: " + aantal);

            aantal = bedrag / 20;
            bedrag %= 20;
            totaalAantalBiljetten += aantal;
            Console.WriteLine("Aantal biljetten van 20  EUR: " + aantal);

            aantal = bedrag / 10;
            bedrag %= 10;
            totaalAantalBiljetten += aantal;
            Console.WriteLine("Aantal biljetten van 10  EUR: " + aantal);

            aantal = bedrag / 5;
            bedrag %= 5;
            totaalAantalBiljetten += aantal;
            Console.WriteLine("Aantal biljetten van 5   EUR: " + aantal);

            aantal = bedrag / 2;
            bedrag %= 2;
            totaalAantalMuntstukken += aantal;
            Console.WriteLine("Aantal muntstukken van 2 EUR: " + aantal);

            aantal = bedrag;
            totaalAantalMuntstukken += aantal;
            Console.WriteLine("Aantal muntstukken van 1 EUR: " + aantal / 1);

            Console.WriteLine();
            Console.WriteLine("Totaal aantal biljetten: " + totaalAantalBiljetten);
            Console.WriteLine("Totaal aantal muntstukken: " + totaalAantalMuntstukken);

            Console.ReadLine();
        }
    }
}
