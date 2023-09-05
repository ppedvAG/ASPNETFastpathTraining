using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPNETFastpathTraining.Models;

namespace ASPNETFastpathTraining.Pages.Modul07.kunden
{
    public class EditModel : PageModel
    {
        private readonly ASPNETFastpathTraining.Models.KundenContext _context;

        public EditModel(ASPNETFastpathTraining.Models.KundenContext context)
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

            var kunde =  await _context.Kundes.FirstOrDefaultAsync(m => m.KundeId == id);
            if (kunde == null)
            {
                return NotFound();
            }
            Kunde = kunde;
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

            _context.Attach(Kunde).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KundeExists(Kunde.KundeId))
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

        private bool KundeExists(int id)
        {
          return (_context.Kundes?.Any(e => e.KundeId == id)).GetValueOrDefault();
        }
    }
}
