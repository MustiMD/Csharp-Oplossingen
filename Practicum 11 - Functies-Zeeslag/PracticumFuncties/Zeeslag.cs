using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_Functies
{
    class Zeeslag
    {
        public Boot Boot1 { get; private set; } = new Boot();
        public Boot Boot2 { get; private set; } = new Boot();
        public Boot Boot3 { get; private set; } = new Boot();

        public int MatrixLengte { get; private set; }
		public int AantalPogingen { get; private set; }
        
        public bool Afgelopen 
        {
            get
            {
                // Afgelopen wanneer alle boten zijn gezonken of het aantal resterende pogingen = 0
                if ((Boot1.Gezonken && Boot2.Gezonken && Boot3.Gezonken) || AantalPogingen == 0)
                {
                    return true;
                }
                return false;
            }
        }

        public int BotenResterend
        {
            get
            {
                // korte oplossing via de ternary if
                return
                    (Boot1.Gezonken ? 0 : 1) +
                    (Boot2.Gezonken ? 0 : 1) +
                    (Boot3.Gezonken ? 0 : 1);

                // kan ook als volgt geschreven worden
                //int botenresterend = 0;
                //if (Boot1.Gezonken)
                //{
                //    botenresterend++;
                //}
                //if (Boot2.Gezonken)
                //{
                //    botenresterend++;
                //}
                //if (Boot3.Gezonken)
                //{
                //    botenresterend++;
                //}
            }
        }

        public int AantalPunten 
        {
            get
            {
                return 
                    (Boot1.Gezonken ? Boot1.Waarde : 0) + 
                    (Boot2.Gezonken ? Boot2.Waarde : 0) + 
                    (Boot3.Gezonken ? Boot3.Waarde : 0);
            }
        }

		public Zeeslag()
		{
            AantalPogingen = 10;
            MatrixLengte = 4;

            Random random = new Random();

            Boot1.Locatie.X = random.Next(1, MatrixLengte + 1);
            Boot1.Locatie.Y = random.Next(1, MatrixLengte + 1);

            Boot2.Locatie.X = random.Next(1, MatrixLengte + 1);
            Boot2.Locatie.Y = random.Next(1, MatrixLengte + 1);

            Boot3.Locatie.X = random.Next(1, MatrixLengte + 1);
            Boot3.Locatie.Y = random.Next(1, MatrixLengte + 1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="locatieBom"></param>
        /// <returns>
        /// 0 - spel is afgelopen
        /// 1 - coordinaten buiten grid
        /// 2 - raak (Boot1 > 3 werd geraakt)
        /// 3 - mis!
        /// </returns>
        public int SmijtBom(Locatie locatieBom)
		{
            if (Afgelopen)
            {
                return 0;
            }

            if (locatieBom.X > MatrixLengte || locatieBom.Y > MatrixLengte)
            {
                return 1;
            }

            AantalPogingen--;

            if (Boot1.Locatie.X == locatieBom.X && Boot1.Locatie.Y == locatieBom.Y)
            {
                Boot1.Gezonken = true;
                return 2; 
            }
            
            if (Boot2.Locatie.X == locatieBom.X && Boot2.Locatie.Y == locatieBom.Y)
            {
                Boot2.Gezonken = true;
                return 2;
            }

            if (Boot3.Locatie.X == locatieBom.X && Boot3.Locatie.Y == locatieBom.Y)
            {
                Boot3.Gezonken = true;
                return 2;
            }

            return 3;
		}


		public string SpelOverzicht()
		{
            string spelOverzicht = "- SPEL OVERZICHT ------------------------------" + Environment.NewLine;
            spelOverzicht += "\tMatrix lengte:\t\t" + MatrixLengte + Environment.NewLine;
            spelOverzicht += "\tAantal pogingen:\t" + AantalPogingen + Environment.NewLine;
            spelOverzicht += "\tAantal boten:\t\t3" + Environment.NewLine;
            spelOverzicht += "------------------------------------------------" + Environment.NewLine;
            return spelOverzicht;
		}

        public string SpelStatus()
        {
            string spelStatus = "- SPEL STATUS ---------------------------------" + Environment.NewLine;
            spelStatus += "\tAantal resterende pogingen:\t" + AantalPogingen + Environment.NewLine;
            spelStatus += "\tAantal gewonnen punten:\t\t" + AantalPunten + Environment.NewLine;
            spelStatus += "\tAantal resterende boten:\t" + BotenResterend + Environment.NewLine;
            
            if (Afgelopen)
            {
                if (BotenResterend == 0)
                {
                    spelStatus += " - GEWONNEN - Alle boten werden gezonken!" + Environment.NewLine;
                }
                else
                {
                    spelStatus += " - VERLOREN - Geen resterende pogingen" + Environment.NewLine;
                }
            }

            spelStatus += "------------------------------------------------" + Environment.NewLine;

            return spelStatus;
        }
    }
}
