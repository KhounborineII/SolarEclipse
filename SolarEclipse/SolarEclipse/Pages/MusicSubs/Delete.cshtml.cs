using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SolarEclipse.Data;
using SolarEclipse.Models;

namespace SolarEclipse.Pages.MusicSubs
{
    public class DeleteModel : PageModel
    {
        private readonly SolarEclipse.Data.SolarEclipseContext _context;

        public DeleteModel(SolarEclipse.Data.SolarEclipseContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MusicSub = await _context.MusicSubs.FindAsync(id);

            if (MusicSub != null)
            {
                _context.MusicSubs.Remove(MusicSub);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/AdminInfo/Index");
        }
    }
}
