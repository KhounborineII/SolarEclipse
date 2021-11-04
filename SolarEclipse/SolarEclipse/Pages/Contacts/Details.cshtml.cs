using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SolarEclipse.Data;
using SolarEclipse.Models;

namespace SolarEclipse.Pages.Contacts
{
    public class DetailsModel : PageModel
    {
        private readonly SolarEclipse.Data.SolarEclipseContext _context;

        public DetailsModel(SolarEclipse.Data.SolarEclipseContext context)
        {
            _context = context;
        }

        public Contact Contact { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contact = await _context.Contacts.FirstOrDefaultAsync(m => m.ID == id);

            if (Contact == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
