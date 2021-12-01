using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SolarEclipse.Data;
using SolarEclipse.Models;

namespace SolarEclipse.Pages.Volunteers
{
    public class CreateModel : PageModel
    {
        private readonly SolarEclipse.Data.SolarEclipseContext _context;

        public CreateModel(SolarEclipse.Data.SolarEclipseContext context)
        {
            _context = context;
        }
        public SelectList Positions { get; set; }
        public IActionResult OnGet()
        {
            Positions = new SelectList(_context.VolunteerPositions, nameof(VolunteerPosition.ID), nameof(VolunteerPosition.Position));
            return Page();
        }

        [BindProperty]
        public Volunteer Volunteer { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Volunteers.Add(Volunteer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
