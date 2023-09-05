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
    public class DeleteModel : PageModel
    {
        private readonly ASPNETFastpathTraining.Models.KundenContext _context;

        public DeleteModel(ASPNETFastpathTraining.Models.KundenContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Kunde Kunde { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Kundes == null)
            {
                return NotFound();
            }

            var kunde = await _context.Kundes.FirstOrDefaultAsync(m => m.KundeId == id);

            if (kunde == null)
            {
                return NotFound();
            }
            else 
            {
                Kunde = kunde;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Kundes == null)
            {
                return NotFound();
            }
            var kunde = await _context.Kundes.FindAsync(id);

            if (kunde != null)
            {
                Kunde = kunde;
                _context.Kundes.Remove(Kunde);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
