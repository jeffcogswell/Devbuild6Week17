using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instruments.Models
{
	public class Instrument
	{
		public int id { get; set; }
		public string kind { get; set; }
		public string color { get; set; }

		//
		// Static members
		//
		public static List<Instrument> Instruments = new List<Instrument>();
		public static int nextId = 1;
	}
}
