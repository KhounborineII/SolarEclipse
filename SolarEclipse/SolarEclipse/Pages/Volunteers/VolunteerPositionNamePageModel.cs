using SolarEclipse.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SolarEclipse.Pages.Volunteers
{
	public class VolunteerPositionNamePageModel : PageModel
	{
		public SelectList VolunteerPositionNameSL { get; set; }

		public void PopulatePositionsDropDownList(SolarEclipseContext _context, object selectedPosition = null)
		{
			var positionsQuery = from p in _context.VolunteerPositions
								 select p;

			VolunteerPositionNameSL = new SelectList(positionsQuery.AsNoTracking(),
								"VolunteerPositionID", "Position", selectedPosition);
		}
	}
}
