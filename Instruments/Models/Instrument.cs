using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Instruments.Models
{
	[Table("instrument")]
	public class Instrument
	{
		[Key]
		public int id { get; set; }
		public string kind { get; set; }
		public string color { get; set; }

		//
		// Static members
		//
		//public static List<Instrument> Instruments = new List<Instrument>();
		//public static int nextId = 1;
		public static MySqlConnection DB;

		public static IEnumerable<Instrument> GetAll()
		{
			return DB.GetAll<Instrument>();
		}

	}
}
