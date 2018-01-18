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
            // bokser informatie ingeven
            Console.WriteLine("Gelieve de wedstrijd gegevens in te geven van\n Bokser 1: ");
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

            // weddenschap aanmaken
            Weddenschap weddenschap = new Weddenschap();
            weddenschap.Wedstrijd = wedstrijd;
            Console.WriteLine("\nWeddenschap: gelieve de volgende informatie in te geven: ");
            
            Console.Write("  Inzet: ");
            weddenschap.Inzet = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("  Bokser naam (1="+ wedstrijd.Bokser1.Naam +"/2="+wedstrijd.Bokser2.Naam+"): ");
                string gekozenBokser = Console.ReadLine();
                if (gekozenBokser == "1")
                {
                    weddenschap.GekozenBokser = wedstrijd.Bokser1;
                }
                else if(gekozenBokser == "2")
                {
                    weddenschap.GekozenBokser = wedstrijd.Bokser2;
                }
            } while (weddenschap.GekozenBokser == null);

            // start de wedstrijd
            Console.Clear();
            Console.WriteLine(wedstrijd.StartWedstrijd());
            Console.WriteLine("\nDe wedstrijd werd gestart!! Inzet = " + weddenschap.Inzet);
            Console.WriteLine("Druk op enter om een te boksen. stop + enter om te stoppen");
            string input = string.Empty;
            do
            {
                input = Console.ReadLine();
                if (input == "stop")
                {
                    Console.WriteLine(wedstrijd.StopWedstrijd());
                    Console.WriteLine(weddenschap.ControleerWedstrijd());
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

