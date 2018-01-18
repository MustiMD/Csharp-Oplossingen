using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOef2
{
    class Computer
    {
        public string MAC { get; set; }
        public string IPaddress { get; set; }
        public string Model { get; set; }

        public Computer(string _MAC)
        {
            MAC = _MAC;
            Model = string.Empty;
            IPaddress = "0.0.0.0";
        }

        public Computer(string _MAC, string _model)
        {
            MAC = _MAC;
            Model = _model;
            IPaddress = "0.0.0.0";
        }

        public override string ToString()
        {
            return "IP adres: " + IPaddress;
        }

        public string Overzicht()
        {
            return "Geselecteerde computer:" + Environment.NewLine +
                   Environment.NewLine +
                   "MAC: " + MAC + Environment.NewLine +
                   "Model: " + Model + Environment.NewLine +
                   "IP adres: " + IPaddress;
            
        }
    }
}
