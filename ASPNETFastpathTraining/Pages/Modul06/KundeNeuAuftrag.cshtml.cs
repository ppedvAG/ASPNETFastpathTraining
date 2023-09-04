using ASPNETFastpathTraining.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETFastpathTraining.Pages.Modul06
{
    public class KundeNeuAuftragModel : PageModel
    {
        KundenContext db;
        public KundeNeuAuftragModel(KundenContext _db)
        {
            db = _db;
                
        }
        public void OnGet()
        {
        }

        public void OnPost(string titel, float preis) {

            var a = new Auftrag() ;
            a.Preis = preis ;
            a.Titel = titel ;
            a.KundeId = 3;
            db.Auftrags.Add(a);
            db.SaveChanges();
            var neueid = a.AuftragId; //nur  zum Zeigen

        } 
    }
}
