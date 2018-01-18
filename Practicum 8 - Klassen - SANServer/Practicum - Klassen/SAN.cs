using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practicum_Klassen
{
    class SAN
    {
        public HardDisk Hardisk1 { get; set; } = new HardDisk();
        public HardDisk Hardisk2 { get; set; } = new HardDisk();
        public bool RaidSet { get; set; }
    }
}
