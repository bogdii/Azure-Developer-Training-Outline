using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VolleyballWebApp.Models;

namespace VolleyballWebApp.Pages.VolleyballPlayers
{
    public class DetailsModel : PageModel
    {
        private readonly VolleyballWebApp.Models.VolleyballDbContext _context;

        public DetailsModel(VolleyballWebApp.Models.VolleyballDbContext context)
        {
            _context = context;
        }

      public VolleyballPlayer VolleyballPlayer { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.VolleyballPlayers == null)
            {
                return NotFound();
            }

            var volleyballplayer = await _context.VolleyballPlayers.FirstOrDefaultAsync(m => m.ID == id);
            if (volleyballplayer == null)
            {
                return NotFound();
            }
            else 
            {
                VolleyballPlayer = volleyballplayer;
            }
            return Page();
        }
    }
}
