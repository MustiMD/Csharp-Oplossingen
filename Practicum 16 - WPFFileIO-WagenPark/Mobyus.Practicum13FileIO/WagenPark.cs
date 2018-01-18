using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobyus.PracticumWPFFileIO_WagenPark
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

        public void WagensInladen()
        {
            Wagens.Clear();
            string[] wagenRecords = File.ReadAllLines("wagens.txt");

            foreach (var wagenRecord in wagenRecords)
            {
                string[] wagenProperties = wagenRecord.Split('\t');
                Wagens.Add(new Wagen
                {
                    Merk = wagenProperties[0],
                    Nummerplaat = wagenProperties[1],
                    Schade = double.Parse(wagenProperties[2])
                });
            }
        }

        public void WagensWegschrijven()
        {
            string output = string.Empty;
            foreach (Wagen wagen in Wagens)
            {
                output += wagen.Merk + "\t" + wagen.Nummerplaat + "\t" + wagen.Schade + Environment.NewLine;
            }
            File.WriteAllText("wagens.txt", output);
        }
    }
}
