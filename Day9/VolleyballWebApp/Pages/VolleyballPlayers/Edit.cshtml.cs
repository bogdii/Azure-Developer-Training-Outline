using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VolleyballWebApp.Models;

namespace VolleyballWebApp.Pages.VolleyballPlayers
{
    public class EditModel : PageModel
    {
        private readonly VolleyballWebApp.Models.VolleyballDbContext _context;

        public EditModel(VolleyballWebApp.Models.VolleyballDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public VolleyballPlayer VolleyballPlayer { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.VolleyballPlayers == null)
            {
                return NotFound();
            }

            var volleyballplayer =  await _context.VolleyballPlayers.FirstOrDefaultAsync(m => m.ID == id);
            if (volleyballplayer == null)
            {
                return NotFound();
            }
            VolleyballPlayer = volleyballplayer;
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

            _context.Attach(VolleyballPlayer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VolleyballPlayerExists(VolleyballPlayer.ID))
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

        private bool VolleyballPlayerExists(int id)
        {
          return (_context.VolleyballPlayers?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
