using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SolarEclipse.Data;
using SolarEclipse.Models;

namespace SolarEclipse.Pages.VolunteerPositions
{
    public class DetailsModel : PageModel
    {
        private readonly SolarEclipse.Data.SolarEclipseContext _context;

        public DetailsModel(SolarEclipse.Data.SolarEclipseContext context)
        {
            _context = context;
        }

        public VolunteerPosition VolunteerPosition { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VolunteerPosition = await _context.VolunteerPositions.FirstOrDefaultAsync(m => m.VolunteerPositionID == id);

            if (VolunteerPosition == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
