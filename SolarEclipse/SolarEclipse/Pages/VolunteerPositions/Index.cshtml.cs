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
    public class IndexModel : PageModel
    {
        private readonly SolarEclipse.Data.SolarEclipseContext _context;

        public IndexModel(SolarEclipse.Data.SolarEclipseContext context)
        {
            _context = context;
        }

        public IList<VolunteerPosition> VolunteerPosition { get;set; }

        public async Task OnGetAsync()
        {
            VolunteerPosition = await _context.VolunteerPositions.ToListAsync();
        }
    }
}
