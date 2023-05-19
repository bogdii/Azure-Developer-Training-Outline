using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VolleyballWebApp.Models;

namespace VolleyballWebApp.Pages.VolleyballPlayers
{
    public class CreateModel : PageModel
    {
        private readonly VolleyballWebApp.Models.VolleyballDbContext _context;

        public CreateModel(VolleyballWebApp.Models.VolleyballDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public VolleyballPlayer VolleyballPlayer { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.VolleyballPlayers == null || VolleyballPlayer == null)
            {
                return Page();
            }

            _context.VolleyballPlayers.Add(VolleyballPlayer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
