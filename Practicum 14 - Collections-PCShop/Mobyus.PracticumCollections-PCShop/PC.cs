using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mobyus.PracticumCollections_PCShop
{
	class PC
	{
		public string Code { get; set; }
		public string TypeProcessor { get; set; }
		public int Geheugen { get; set; }
		public int Hardeschijf { get; set; }

		public PC()
		{
			Code = "";
			TypeProcessor = "";
			Geheugen = 0;
			Hardeschijf = 0;
		}

		public PC(string code, string typeProcessor, int geheugen, int hardeschijf)
		{
			Code = code;
			TypeProcessor = typeProcessor;
			Geheugen = geheugen;
			Hardeschijf = hardeschijf;
		}

		public string Omschrijving()
		{
			return "Code: " + Code + "\t| CPU: " + TypeProcessor + " \t| Geheugen: " + Geheugen + " Gb \t| Hardeschijf: " + Hardeschijf + " Gb";
		}
	}
}
