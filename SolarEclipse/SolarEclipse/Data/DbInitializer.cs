using SolarEclipse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolarEclipse.Data
{
	public class DbInitializer
	{
		public static void Initialize(SolarEclipseContext context)
		{
			if (context.VolunteerPositions.Any())
			{
				return;
			}

			var volunteerPositions = new VolunteerPosition[]
			{
				new VolunteerPosition{
					Position = "Glasses Table",
					TimeStart = DateTime.Parse("2017-09-01"),
					PositionsFilled = "3/14"}
			};
		}
	}
}
