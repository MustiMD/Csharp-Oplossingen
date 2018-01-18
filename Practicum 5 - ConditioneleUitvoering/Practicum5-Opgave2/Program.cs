using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum4_Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomGetal = (new Random()).Next(11);
            Console.Write("Raad het getal (1 > 10): ");
            int input = int.Parse(Console.ReadLine());

            if (randomGetal == input)
            {
                Console.WriteLine("Correct geraden! Het getal was " + input);
            }
            else
            {
                Console.WriteLine("Spijtig, het getal was: " + randomGetal);
            }
            Console.ReadKey();
        }
    }
}
