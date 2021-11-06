using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolarEclipse.Models
{
	public class Volunteer
	{
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public VolunteerPosition Position { get; set; }
		public DateTime TimeStart { get; set; }
	}
}
