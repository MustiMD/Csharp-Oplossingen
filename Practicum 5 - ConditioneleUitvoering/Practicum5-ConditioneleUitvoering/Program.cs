using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum4_ConditioneleUitvoering
{
    class Program
    {
        static void Main(string[] args)
        {
            string keuze = "";
            double temperatuur = 0;
            double temperatuurCelcius = 0;
            double temperatuurFahrenheit = 0;
            double temperatuurKelvin = 0;

            Console.WriteLine("Gelieve de temperatuurschaal te kiezen: ");
            Console.WriteLine("1. Celcius");
            Console.WriteLine("2. Kelvin");
            Console.WriteLine("3. Fahrenheit");
            Console.Write(" > ");
            keuze = Console.ReadLine();

            if (keuze == "1" || keuze == "2" || keuze == "3")
            {
                Console.Write("Gelieve de huidige temperatuur in de gekozen schaal in te geven: ");
                temperatuur = double.Parse(Console.ReadLine());

                switch (keuze)
                {
                    case "1":
                        temperatuurCelcius = temperatuur;
                        temperatuurFahrenheit = ((9.0 * temperatuurCelcius) / 5.0) + 32;
                        temperatuurKelvin = temperatuurCelcius + 273.15;
                        break;
                    case "2":
                        temperatuurKelvin = temperatuur;
                        temperatuurCelcius = temperatuurKelvin - 273.15;
                        temperatuurFahrenheit = ((9.0 * temperatuurCelcius) / 5.0) + 32;
                        break;
                    case "3":
                        temperatuurFahrenheit = temperatuur;
                        temperatuurCelcius = (temperatuurFahrenheit - 32) * (5.0 / 9.0);
                        temperatuurKelvin = temperatuurCelcius + 273.15;
                        break;
                    default:
                        break;
                }

                if (temperatuurKelvin < 0)
                {
                    Console.WriteLine("Ongeldige temperatuur! Het programma wordt afgesloten");
                }
                else
                {
                    Console.WriteLine("\nOverzicht in alle temperatuur schalen:");
                    Console.WriteLine("Celcius\t\t:\t" + temperatuurCelcius);
                    Console.WriteLine("Fahrenheit\t:\t" + temperatuurFahrenheit);
                    Console.WriteLine("Kelvin\t\t:\t" + temperatuurKelvin);
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Ongeldige temperatuurschaal. Het programma zal afsluiten");
            }
        }
    }
}