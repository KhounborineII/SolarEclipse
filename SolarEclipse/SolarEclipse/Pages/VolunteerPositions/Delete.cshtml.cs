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
    public class DeleteModel : PageModel
    {
        private readonly SolarEclipse.Data.SolarEclipseContext _context;

        public DeleteModel(SolarEclipse.Data.SolarEclipseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public VolunteerPosition VolunteerPosition { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VolunteerPosition = await _context.VolunteerPositions.FirstOrDefaultAsync(m => m.ID == id);

            if (VolunteerPosition == null)
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

            VolunteerPosition = await _context.VolunteerPositions.FindAsync(id);

            if (VolunteerPosition != null)
            {
                _context.VolunteerPositions.Remove(VolunteerPosition);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
