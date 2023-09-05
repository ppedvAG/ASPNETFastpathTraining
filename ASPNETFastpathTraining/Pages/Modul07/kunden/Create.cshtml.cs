using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASPNETFastpathTraining.Models;

namespace ASPNETFastpathTraining.Pages.Modul07.kunden
{
    public class CreateModel : PageModel
    {
        private readonly ASPNETFastpathTraining.Models.KundenContext _context;

        public CreateModel(ASPNETFastpathTraining.Models.KundenContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Kunde Kunde { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Kundes == null || Kunde == null)
            {
                return Page();
            }

            _context.Kundes.Add(Kunde);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
