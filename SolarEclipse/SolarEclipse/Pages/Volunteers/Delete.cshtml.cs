using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SolarEclipse.Data;
using SolarEclipse.Models;

namespace SolarEclipse.Pages.Volunteers
{
    public class DeleteModel : PageModel
    {
        private readonly SolarEclipse.Data.SolarEclipseContext _context;

        public DeleteModel(SolarEclipse.Data.SolarEclipseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Volunteer Volunteer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Volunteer = await _context.Volunteers
                .AsNoTracking()
                .Include(v => v.Position)
                .FirstOrDefaultAsync(m => m.VolunteerID == id);

            if (Volunteer == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Volunteer = await _context.Volunteers.FindAsync(id);

            if (Volunteer != null)
            {
                _context.Volunteers.Remove(Volunteer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/AdminInfo/Index");
        }
    }
}
