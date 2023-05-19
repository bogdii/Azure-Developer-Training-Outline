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
    public class IndexModel : PageModel
    {
        private readonly VolleyballWebApp.Models.VolleyballDbContext _context;

        public IndexModel(VolleyballWebApp.Models.VolleyballDbContext context)
        {
            _context = context;
        }

        public IList<VolleyballPlayer> VolleyballPlayer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.VolleyballPlayers != null)
            {
                VolleyballPlayer = await _context.VolleyballPlayers.ToListAsync();
            }
        }
    }
}
