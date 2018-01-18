using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOef1
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;
            List<int> getallen = new List<int>();
            do
            {
                bool test;
                do
                {
                    Console.Write("Geef een getal in (0 om te stoppen): ");
                    test = int.TryParse(Console.ReadLine(), out getal);
                } while (!test);
                if (getal != 0)
                {
                    getallen.Add(getal);
                }
            } while (getal != 0);

            int lastIndex = getallen.Count() - 1;

            Console.WriteLine("Min > Max");
            getallen.Sort();
            for (int i = 0; i <= lastIndex; i++)
            {
                Console.Write(getallen.ElementAt(i));
                if (i != lastIndex)
                {
                    Console.Write(" - ");
                }
            }

            
            Console.WriteLine("\nMax > Min");
            getallen.Reverse();
            for (int i = 0; i <= lastIndex; i++)
            {
                Console.Write(getallen.ElementAt(i));
                if (i != lastIndex)
                {
                    Console.Write(" - ");
                }
            }

            Console.ReadLine();
        }
    }
}
