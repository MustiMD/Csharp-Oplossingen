using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobyus.Practicum_Klassen
{
    class SimKaart
    {
        private DateTime datumLaatsteOproep;

        public string GsmNummer { get; set; }
        public DateTime CreatieDatum { get; set; } = DateTime.Now;
        public int AantalOproepen { get; private set; }
        public string Code { get; set; }

        public DateTime DatumLaatsteOproep
        {
            get { return datumLaatsteOproep; }
            set 
            { 
                datumLaatsteOproep = value;
                AantalOproepen++;
            }
        }
    }
}
