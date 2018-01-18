using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobyus.PracticumCollections_PCShop
{
	class PCShop
	{
		public List<PC> PCVoorraad { get; private set; }

		public PCShop()
		{
			PCVoorraad = new List<PC>();
		}

		public void PcToevoegen(PC pc)
		{
			PCVoorraad.Add(pc);
		}

		public List<PC> SelectieOpGeheugen(int geheugen)
		{
			List<PC> perGeheugen = new List<PC>();
			foreach (PC pc in PCVoorraad)
			{
				if (pc.Geheugen == geheugen)
				{
					perGeheugen.Add(pc);
				}
			}
			return perGeheugen;
		}

		public List<PC> SelectieOpHardeschijf(int hardeschijf)
		{
			List<PC> perHardeSchijf = new List<PC>();
			foreach (PC pc in PCVoorraad)
			{
				if (pc.Hardeschijf == hardeschijf)
				{
					perHardeSchijf.Add(pc);
				}
			}
			return perHardeSchijf;
		}

		public List<PC> SelectieOpTypeProcessor(string typeProcessor)
		{
			List<PC> perTypeProcessor = new List<PC>();
			foreach (PC pc in PCVoorraad)
			{
				if (pc.TypeProcessor == typeProcessor)
				{
					perTypeProcessor.Add(pc);
				}
			}
			return perTypeProcessor;
		}

		public bool KoopPC(string code)
		{
			foreach (PC pc in PCVoorraad)
			{
				if (pc.Code == code)
				{
					PCVoorraad.Remove(pc);
					return true;
				}
			}
			return false;
		}
	}
}
