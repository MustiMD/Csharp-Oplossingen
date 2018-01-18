using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_Functies
{
    class Program
    {
        static void Main(string[] args)
        {
            Zeeslag zeeslag = new Zeeslag();
            Console.WriteLine(zeeslag.SpelOverzicht());
            Console.WriteLine("Druk op een toets om het spel te starten");
            Console.ReadKey();

            do
            {
                Console.Clear();
                Console.WriteLine(zeeslag.SpelStatus());
                
                Console.WriteLine("Smijt een bom! Geef de X en Y coordinaten in");
                Locatie locatieBom = new Locatie();
                Console.Write("X: ");
                locatieBom.X = int.Parse(Console.ReadLine());
                Console.Write("Y: ");
                locatieBom.Y = int.Parse(Console.ReadLine());
                int result = zeeslag.SmijtBom(locatieBom);
                Console.WriteLine();

                switch (result)
                {
                    case 0:
                        Console.WriteLine("Het spel is afgelopen");
                        break;
                    case 1:
                        Console.WriteLine("Verkeerde coordinaten. Maximum waarde = " + zeeslag.MatrixLengte);
                        break;
                    case 2:
                        Console.WriteLine("RAAK!!");
                        break;
                    case 3:
                        Console.WriteLine("MIS!!");
                        break;
                    default:
                        Console.WriteLine("Return niet gekend");
                        break;
                }

                Console.WriteLine("Druk op een toets");
                Console.ReadKey();
            } while (!zeeslag.Afgelopen);

            Console.Clear();
            Console.WriteLine(zeeslag.SpelStatus());
            Console.WriteLine();
            Console.WriteLine("Druk op een toets om af te sluiten");
            Console.ReadKey();
        }
    }
}
