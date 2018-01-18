using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobyus.PracticumFuncties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gelieve de gegeven in te geven van\n Bokser 1: ");
            Bokser bokser1 = new Bokser();
            Console.Write("   Naam: " );
            bokser1.Naam = Console.ReadLine();
            Console.Write("   Ranking: ");
            bokser1.Ranking = int.Parse(Console.ReadLine());
            Console.Write("   Gewicht: ");
            bokser1.Gewicht = float.Parse(Console.ReadLine());

            Bokser bokser2 = new Bokser();
            Console.WriteLine("\n Bokser 2:");
            Console.Write("   Naam: ");
            bokser2.Naam = Console.ReadLine();
            Console.Write("   Ranking: ");
            bokser2.Ranking = int.Parse(Console.ReadLine());
            Console.Write("   Gewicht: ");
            bokser2.Gewicht = float.Parse(Console.ReadLine());

            Console.WriteLine("\nDe volgende bokser gegevens werden ingegeven:");
            Console.WriteLine(bokser1.GeefOmschrijving());
            Console.WriteLine(bokser2.GeefOmschrijving());

            Console.ReadLine();
        }
    }
}
