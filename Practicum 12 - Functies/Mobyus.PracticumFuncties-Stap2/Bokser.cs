using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moybus.PracticumFuncties
{
    class Bokser
    {
        private float gewicht;
        private int ranking;

        public int Ranking
        {
            get { return ranking; }
            set
            {
                if (value < 0)
                {
                    ranking = 0;
                }
                ranking = value;
            }
        }

        public float Gewicht
        {
            get { return gewicht; }
            set
            {
                if (value < 0)
                {
                    gewicht = 0;
                }
                gewicht = value;
            }
        }

        public string Naam { get; set; }


        public string GeefOmschrijving()
        {
            return "Bokser - Naam: " + Naam + " / Ranking: " + Ranking + " / Gewicht: " + Gewicht;
        }
    }
}
