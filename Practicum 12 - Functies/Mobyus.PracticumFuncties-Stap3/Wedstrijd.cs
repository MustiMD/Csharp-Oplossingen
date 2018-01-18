using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobyus.PracticumFuncties
{
    class Wedstrijd
    {
        public int Status { get; private set; }
        public Bokser Bokser1 { get; set; }
        public Bokser Bokser2 { get; set; }
        public int PuntenBokser1 { get; private set; }
        public int PuntenBokser2 { get; private set; }
        public float QuoteringBokser1 { get; private set; }
        public float QuoteringBokser2 { get; private set; }

        public string StartWedstrijd()
        {
            if (Bokser1 == null)
            {
                return "Bokser 1 is nog niet gekend!";
            }
            if (Bokser2 == null)
            {
                return "Bokser 2 is nog niet gekend!";
            }

            Status = 1;
            PuntenBokser1 = 0;
            PuntenBokser2 = 0;
            Random kansen = new Random();
            QuoteringBokser1 = kansen.Next(1, 3001) / 100f;
            QuoteringBokser2 = kansen.Next(1, 3001) / 100f;

            string overzicht = "***** BOKSWEDSTRIJD ******" + Environment.NewLine;
            overzicht += "*   Bokser1: " + Bokser1.Naam + Environment.NewLine;
            overzicht += "*     Quotering : " + QuoteringBokser1 + Environment.NewLine;
            overzicht += "*     Punten    : " + PuntenBokser1 + Environment.NewLine;
            overzicht += "*   Bokser2: " + Bokser2.Naam + Environment.NewLine;
            overzicht += "*     Quotering : " + QuoteringBokser2 + Environment.NewLine;
            overzicht += "*     Punten    : " + PuntenBokser2 + Environment.NewLine;
            overzicht += "****************************" + Environment.NewLine;
            return overzicht;
        }

        public string RegistreerUithaal(Bokser bokser)
        {
            Random random = new Random();
            if (bokser == Bokser1)
            {
                PuntenBokser1 += random.Next(1, 10);
            }
            else
            {
                PuntenBokser2 += random.Next(1, 10);
            }

            // als je geen info wil geven aan de gebruiker:
            //return string.Empty;

            string overzicht = " * Punten bokser 1: " + PuntenBokser1 + Environment.NewLine;
            overzicht += " * Punten bokser 2: " + PuntenBokser2 + Environment.NewLine;

            return overzicht;
        }

        public string StopWedstrijd()
        {
            Status = 2;
            string overzicht = "**** EIND WEDSTRIJD ****" + Environment.NewLine;
            if (PuntenBokser1 > PuntenBokser2)
            {
                Bokser1.Ranking++;
                return overzicht + "De winnaar is " + Bokser1.Naam + "!! (" + PuntenBokser1 + " punten)";
            }
            else if (PuntenBokser2 > PuntenBokser1)
            {
                Bokser2.Ranking++;
                return overzicht + "De winnaar is " + Bokser2.Naam + "!! (" + PuntenBokser2 + " punten)";
            }
            else
            {
                return overzicht + "Beide boksers behaalde evenveel punten (" + PuntenBokser1 + " punten)";
            }
        }
    }
}