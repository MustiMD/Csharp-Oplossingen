using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobyus.Practicum10_Collections
{
    class Wagen
    {
        public string Nummerplaat { get; set; }
        public string Merk { get; set; }
        public double Schade { get; set; }

        public Wagen()
        {
            Schade = 0;
            Nummerplaat = string.Empty;
            Merk = string.Empty;
        }

        public Wagen(string nummerplaat, string merk)
        {
            Schade = 0;
            Nummerplaat = nummerplaat;
            Merk = merk;
        }

        
    }
}
