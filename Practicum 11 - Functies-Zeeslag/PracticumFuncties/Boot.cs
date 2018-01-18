using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practicum_Functies
{
    class Boot
    {
        /// <summary>
        /// Locatie van de boot (X Y coordinaten in matrix)
        /// </summary>
        public Locatie Locatie { get; set; } = new Locatie();
        
        /// <summary>
        /// Waarde boot = aantal punten te verdienen indien gevonden
        /// </summary>
        public int Waarde { get; private set; } = new Random(Guid.NewGuid().GetHashCode()).Next(1, 6);

        /// <summary>
        /// Boot status
        /// false - niet gezonken
        /// true - gezonken
        /// </summary>
        public bool Gezonken { get; set; } = false;

    }
}
