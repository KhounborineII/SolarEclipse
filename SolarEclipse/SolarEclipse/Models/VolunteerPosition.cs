using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolarEclipse.Models
{
	public class VolunteerPosition
	{
		public int ID { get; set; }
		public string Position { get; set; }
		public DateTime TimeStart { get; set; }
		public string PositionsFilled { get; set; }
	}
}
