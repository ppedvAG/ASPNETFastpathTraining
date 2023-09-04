using ASPNETFastpathTraining.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ASPNETFastpathTraining.Pages.Modul06
{
    public class SucheModel : PageModel
    {
        public void OnGet([FromServices] KundenContext db)
        {
            //Fake Code
           var x= db.Kundes.Include(x=>x.Auftrags).Where(x => x.Name.Contains(Request.Query["suchtext"]));
        }
    }
}
