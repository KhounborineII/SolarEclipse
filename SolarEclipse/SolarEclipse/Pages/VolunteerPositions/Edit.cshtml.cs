using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SolarEclipse.Data;
using SolarEclipse.Models;

namespace SolarEclipse.Pages.VolunteerPositions
{
    public class EditModel : PageModel
    {
        private readonly SolarEclipse.Data.SolarEclipseContext _context;

        public EditModel(SolarEclipse.Data.SolarEclipseContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(VolunteerPosition).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VolunteerPositionExists(VolunteerPosition.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool VolunteerPositionExists(int id)
        {
            return _context.VolunteerPositions.Any(e => e.ID == id);
        }
    }
}
