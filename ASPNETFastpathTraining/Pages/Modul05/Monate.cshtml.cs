using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETFastpathTraining.Pages.Modul05
{
    public class MonateModel : PageModel
    {
        [BindProperty(Name ="monat",SupportsGet =true)]
        public int Monat { get; set; }
        public void OnGet()
        {
        }
    }
}
