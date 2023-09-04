using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETFastpathTraining.Pages
{
    public class ProduktListeModel : PageModel
    {
        public List<Produkt> Produkte;

        public void OnGet()
        {

            Produkte = new List<Produkt>()
            {   
                new Produkt() {Name="Produkt 1",Preis=10.99},
                new Produkt() {Name="Produkt 2",Preis=19.99},
                new Produkt() {Name="Produkt 3",Preis=5.49},
            };

        }
    }
    public class Produkt
    {
        public string Name { get; set; }
        public double Preis { get; set; }
    }
}
