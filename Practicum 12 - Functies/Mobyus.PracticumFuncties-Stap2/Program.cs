using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moybus.PracticumFuncties
{
    class Program
    {
        static void Main(string[] args)
        {
            // bokser informatie ingeven
            Console.WriteLine("Gelieve de gegeven in te geven van\n Bokser 1: ");
            Bokser bokser1 = new Bokser();
            Console.Write("   Naam: ");
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

            // wedstrijd aanmaken + de boksers toewijzen. vervolgens de wedstrijd starten
            Wedstrijd wedstrijd = new Wedstrijd();
            wedstrijd.Bokser1 = bokser1;
            wedstrijd.Bokser2 = bokser2;
            

            // start de wedstrijd
            Console.Clear();
            Console.WriteLine(wedstrijd.StartWedstrijd());
            Console.WriteLine("\nDe wedstrijd werd gestart!!");
            Console.WriteLine("Druk op enter om een te boksen. stop + enter om te stoppen");
            string input = string.Empty;
            do
            {
                input = Console.ReadLine();
                if (input == "stop")
                {
                    Console.WriteLine(wedstrijd.StopWedstrijd());
                }
                else
                {
                    if (new Random().Next(1, 3) == 1)
                    {
                        Console.WriteLine(wedstrijd.RegistreerUithaal(wedstrijd.Bokser1));
                    }
                    else
                    {
                        Console.WriteLine(wedstrijd.RegistreerUithaal(wedstrijd.Bokser2));
                    }
                }
            } while (wedstrijd.Status == 1);


            Console.ReadLine();
        }
    }
}
