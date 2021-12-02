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
    public class CreateModel : VolunteerPositionNamePageModel
    {
        private readonly SolarEclipse.Data.SolarEclipseContext _context;

        public CreateModel(SolarEclipse.Data.SolarEclipseContext context)
        {
            _context = context;
        }
        public SelectList Positions { get; set; }
        public IActionResult OnGet()
        {
            PopulatePositionsDropDownList(_context);
            return Page();
        }

        [BindProperty]
        public Volunteer Volunteer { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyVolunteer = new Volunteer();
            
            if (await TryUpdateModelAsync<Volunteer>(
                emptyVolunteer,
                "volunteer",
                s => s.VolunteerID, s => s.VolunteerPositionID, s => s.FirstName, s => s.LastName, s => s.Email))
            {
                _context.Volunteers.Add(emptyVolunteer);
                await _context.SaveChangesAsync();
                return RedirectToPage("/VolunteerPositions/Index");
            }

            PopulatePositionsDropDownList(_context, emptyVolunteer.VolunteerPositionID);
            return Page();
        }
    }
}
