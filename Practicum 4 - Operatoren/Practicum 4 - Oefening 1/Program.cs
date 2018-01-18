using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practicum_4___Oefening_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gelieve de volgende gegevens van de cilinder in te geven: ");
            Console.Write(" - Straal (cm): ");
            double straal = double.Parse(Console.ReadLine());
            Console.Write(" - Hoogte (cm): ");
            double hoogte = double.Parse(Console.ReadLine());

            double oppervlakte = ((2 * Math.PI * straal) * hoogte) + (2 * Math.PI * Math.Pow(straal, 2));
            double inhoud = (Math.PI * Math.Pow(straal, 2)) * hoogte;

            Console.WriteLine();
            Console.WriteLine("De oppervlakte van de cilinder is: " + Math.Round(oppervlakte, 2) + " cm²");
            Console.WriteLine("De inhoud van de cilinder is: " + Math.Round(inhoud, 2) + " cm³");
            Console.ReadLine();
        }
    }
}
