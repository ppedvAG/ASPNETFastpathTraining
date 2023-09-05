using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPNETFastpathTraining.Models;

namespace ASPNETFastpathTraining.Pages.Modul07.kunden
{
    public class IndexModel : PageModel
    {
        private readonly ASPNETFastpathTraining.Models.KundenContext _context;

        public IndexModel(ASPNETFastpathTraining.Models.KundenContext context)
        {
            _context = context;
        }

        public IList<Kunde> Kunde { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Kundes != null)
            {
                Kunde = await _context.Kundes.ToListAsync();
            }
        }
    }
}
