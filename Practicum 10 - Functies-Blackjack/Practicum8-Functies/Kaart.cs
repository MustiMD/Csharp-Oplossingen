using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum8_Functies
{
    class Kaart
    {
        public int Waarde { get; private set; } = new Random().Next(1, 14);

        public string Omschrijving
        {
            get
            {
                if (Waarde < 10)
                {
                    return Waarde.ToString();
                }
                else
                {
                    switch (Waarde)
                    {
                        case 11:
                            return "Boer";
                        case 12:
                            return "Dame";
                        case 13:
                            return "Heer";
                        default:
                            return "Ongeldige waarde";
                    }
                }
            }
        }
    }
}
