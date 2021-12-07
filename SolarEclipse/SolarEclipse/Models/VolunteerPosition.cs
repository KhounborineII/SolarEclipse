using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolarEclipse.Models
{
	public class VolunteerPosition
	{
		public int VolunteerPositionID { get; set; }
		[Required]
		public string Position { get; set; }
		[Required]
		[Display(Name = "Start Time")]
		public DateTime TimeStart { get; set; }
		[Required]
		[Display(Name = "Spots Filled")]
		public string PositionsFilled { get; set; }
	}
}
