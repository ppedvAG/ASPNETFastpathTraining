using ASPNETFastpathTraining.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ASPNETFastpathTraining.Pages.Modul06
{
    public class EFModel : PageModel
    {

        public void OnGet([FromServices] KundenContext db)
        {
            string par1 = "e";

            FormattableString sql = $"select * from kunden where name like '%{par1}%' "; //verhinder SQLINjecton

            var liste = db.Database.SqlQuery<Kunde>(sql).ToList(); //nur zur Demo Hinweis [Notmapped]

        }
    }
}
