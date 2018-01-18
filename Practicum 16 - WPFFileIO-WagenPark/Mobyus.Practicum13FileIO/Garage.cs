using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobyus.PracticumWPFFileIO_WagenPark
{
    class Garage
    {
        public string Merk { get; set; }
        public string Naam { get; set; }

        public Garage()
        {
            Naam = string.Empty;
            Merk = string.Empty;
        }

        public Garage(string naam, string merk)
        {
            Naam = naam;
            Merk = merk;
        }

        public double RepareerWagen(Wagen wagen)
        {
            double kost = wagen.Schade;
            wagen.Schade = 0;
            return kost;
        }
    }
}
