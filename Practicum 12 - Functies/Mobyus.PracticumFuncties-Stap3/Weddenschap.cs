using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobyus.PracticumFuncties
{
    class Weddenschap
    {
        public Wedstrijd Wedstrijd { get; set; }
        public Bokser GekozenBokser { get; set; }
        public int Inzet { get; set; }
        
        
        public string ControleerWedstrijd()
        {
            if (Wedstrijd == null)
            {
                return "Er werd nog geen wedstrijd toegewezen.";
            }

            if (Wedstrijd.Status != 2)
            {
                return "Wedstrijd is nog niet afgelopen";
            }
            
            if (Wedstrijd.PuntenBokser1 > Wedstrijd.PuntenBokser2)
            {
                // aangezien de GekozenBokser property gelijk gezet wordt aan de Wedstrijd.Bokser1 of Wedstrijd.Bokser2 property 
                // kan je hier beide objecten met elkaar vergelijken op gelijkheid => er wordt door beide properties naar hetzelfde
                // object verwezen

                // Wedstrijd wedstrijd = new Wedstrijd();
                // wedstrijd.Bokser1 = new Bokser{ Naam = "test", Ranking = 1, Gewicht = 80.2f};
                // weddenschap.GekozenBokser = wedstrijd.Bokser1:
                //                                                   _______________
                // Wedstrijd.Bokser1 -----------------------------> | Bokser object |
                //                                                   ---------------
                //                                                         ^
                // Weddenschap.GekozenBokser ------------------------------|

                if (Wedstrijd.Bokser1 == GekozenBokser)
                {
                    return "Gewonnen! Winst = " + Inzet * Wedstrijd.QuoteringBokser1;
                }
                else
                {
                    return "Verloren.... Verlies = " + Inzet;
                }
            }
            else if (Wedstrijd.PuntenBokser2 > Wedstrijd.PuntenBokser1)
            {
                if (Wedstrijd.Bokser2 == GekozenBokser)
                {
                    return "Gewonnen! Winst = " + Inzet * Wedstrijd.QuoteringBokser2;
                }
                else
                {
                    return "Verloren.... Verlies = " + Inzet;
                }
            }
            else
            {
                return "Geen Winnaar";
            }


            
        }
    }
}
