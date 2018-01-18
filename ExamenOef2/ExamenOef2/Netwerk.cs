using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOef2
{
    class Netwerk
    {
        public Dictionary<string, Computer> Computers { get; set; } = new Dictionary<string, Computer>();
        public List<string> IP { get; set; } = new List<string>();

        public Netwerk()
        {
            IP.Add("192.168.1.1");
            IP.Add("192.168.1.2");
            IP.Add("192.168.1.3");
            IP.Add("192.168.1.4");
            IP.Add("192.168.1.5");
        }
        public string VoegComputerToe(Computer c)
        {
            //GetIpAdres(c);
            if (GetIpAdres(c))
            {
                Computers.Add(c.MAC, c);
                return "De computer werd aan het netwerk gekoppeld";
            }
            else
            {
                c.IPaddress = "0.0.0.0";
                return "Geen IP adres beschikbaar";
            }
            
        }

        private bool GetIpAdres(Computer c)
        {
            if (!IP.Any())
            {
                return false;
            }
            c.IPaddress = IP.First();
            IP.Remove(c.IPaddress);
            return true;
        }
    }
}
