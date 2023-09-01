using ASPNETFastpathTraining.Klassen;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETFastpathTraining.Pages.Modul01
{
    public class IndexModel : PageModel
    {
        public Zaehler ZaehlerObjekt { get; set; }
        public IndexModel(Zaehler _zahler)
        {
                ZaehlerObjekt = _zahler;
        }
        public void OnGet()
        {
            ZaehlerObjekt.Anzahl++;
        }
    }
}
