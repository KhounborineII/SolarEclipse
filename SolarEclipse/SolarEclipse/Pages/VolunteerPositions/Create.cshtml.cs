using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SolarEclipse.Data;
using SolarEclipse.Models;

namespace SolarEclipse.Pages.VolunteerPositions
{
    public class CreateModel : PageModel
    {
        private readonly SolarEclipse.Data.SolarEclipseContext _context;

        public CreateModel(SolarEclipse.Data.SolarEclipseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public VolunteerPosition VolunteerPosition { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.VolunteerPositions.Add(VolunteerPosition);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
