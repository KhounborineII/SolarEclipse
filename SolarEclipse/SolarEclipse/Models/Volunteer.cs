using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolarEclipse.Models
{
	public class Volunteer
	{
		public int VolunteerID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		public int VolunteerPositionID { get; set; }
		public VolunteerPosition Position { get; set; }
	}
}
