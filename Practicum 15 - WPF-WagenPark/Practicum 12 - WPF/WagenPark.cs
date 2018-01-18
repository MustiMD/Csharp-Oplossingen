using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticumWPF_WagenPark
{
    class WagenPark
    {
        public List<Wagen> Wagens { get; private set; }
        public WagenPark()
        {
            Wagens = new List<Wagen>();
        }

        /// <summary>
        /// Voegt de wagen toe aan de collection van wagens
        /// </summary>
        /// <param name="wagen">De in te schrijven wagen</param>
        /// <returns>true: inschrijving ok / false: nummerplaat van wagen niet gekend</returns>
        public bool SchrijfWagenIn(Wagen wagen)
        {
            if (string.IsNullOrEmpty(wagen.Nummerplaat))
            {
                return false;
            }
            else
            {
                Wagens.Add(wagen);
                return true;
            }
        }

        public string GeefOverzicht()
        {
            string overzicht = "*** Wagenpark Overzicht ***\n";

            foreach (Wagen wagen in Wagens)
            {
                overzicht += " - " + wagen.Nummerplaat + " /Merk: " + wagen.Merk + " / Schade: " + wagen.Schade.ToString() + Environment.NewLine;
            }
            return overzicht;
        }

        public Wagen ZoekWagen(string nummerplaat)
        {
            foreach (var wagen in Wagens)
            {
                if (wagen.Nummerplaat == nummerplaat)
                {
                    return wagen;
                }
            }
            return null;
        }

    }
}
