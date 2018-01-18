using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum8_Functies
{
    class Blackjack
    {
        public int TotaalKaarten { get; private set; }
        public double Inzet { get; private set; }
        public string SpelStatus { get; private set; }

        public string TrekKaart()
        {
            Kaart kaart = new Kaart();
            TotaalKaarten += kaart.Waarde;

            if (TotaalKaarten > 21)
            {
                SpelStatus = "0";
            }
            else if (TotaalKaarten < 21)
            {
                SpelStatus = "1";
            }
            else
            {
                SpelStatus = "2";
            }

            return "Getrokken kaart: " + kaart.Omschrijving + " (Waarde: " + kaart.Waarde.ToString() + ")";
        }

        public bool BepaalInzet(double inzet)
        {
            if (inzet < 0)
            {
                return false;
            }
            else
            {
                Inzet = inzet;
                return true;
            }
        }

        public string GeefOverzicht()
        {
            string overzicht = "Spel overzicht:" + Environment.NewLine +
                "  Inzet: " + Inzet.ToString() + Environment.NewLine +
                "  Totaal kaarten: " + TotaalKaarten.ToString() + Environment.NewLine +
                "  Status: ";

            switch (SpelStatus)
            {
                case "0":
                    overzicht += "Verloren - Verlies = " + Inzet;
                    break;
                case "1":
                    overzicht += "Spel gestart";
                    break;
                case "2":
                    overzicht += "Gewonnen!! - Winst = " + (Inzet * 2);
                    break;
                default:
                    overzicht += "Niet gekend";
                    break;
            }
            return overzicht;
        }

    }
}
