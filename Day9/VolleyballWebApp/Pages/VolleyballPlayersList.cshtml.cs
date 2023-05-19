using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VolleyballWebApp.Models;

namespace VolleyballWebApp.Pages
{
    public class VolleyballPlayersListModel : PageModel
    {
        private readonly VolleyballDbContext _context;
        public VolleyballPlayersListModel(VolleyballDbContext context)
        {
            _context = context;
        }

        public List<VolleyballPlayer> VolleyballPlayers { get; set; }
        public void OnGet()
        {
            VolleyballPlayers = _context.VolleyballPlayers
                .ToList();
        }
    }
}
