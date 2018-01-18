using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobyus.PracticumWPFFileIO_WagenPark
{
    class ExpertiseBureau
    {
        public void VoerExpertiseUit(List<Wagen> wagens)
        {
            Random random = new Random();
            foreach (var wagen in wagens)
            {
                double schade = random.NextDouble() * 10000;
                wagen.Schade += Math.Round(schade, 2);
            }
        }
    }
}
