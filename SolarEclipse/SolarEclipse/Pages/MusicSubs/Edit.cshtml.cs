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

namespace SolarEclipse.Pages.MusicSubs
{
    public class EditModel : PageModel
    {
        private readonly SolarEclipse.Data.SolarEclipseContext _context;

        public EditModel(SolarEclipse.Data.SolarEclipseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MusicSub MusicSub { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MusicSub = await _context.MusicSubs.FirstOrDefaultAsync(m => m.ID == id);

            if (MusicSub == null)
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

            _context.Attach(MusicSub).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MusicSubExists(MusicSub.ID))
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

        private bool MusicSubExists(int id)
        {
            return _context.MusicSubs.Any(e => e.ID == id);
        }
    }
}
