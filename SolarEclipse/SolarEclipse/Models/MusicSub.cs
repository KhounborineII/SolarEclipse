using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolarEclipse.Models
{
	public class MusicSub
	{
		public int ID { get; set; }
		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		[Required]
		public string Artist { get; set; }
		[Required]
		public string Song { get; set; }
		[Display(Name = "Music Link")]
		[DataType(DataType.Url)]
		public string MusicLink { get; set; }
	}
}
