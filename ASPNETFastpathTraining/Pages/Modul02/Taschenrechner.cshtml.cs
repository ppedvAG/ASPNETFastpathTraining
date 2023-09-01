using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETFastpathTraining.Pages.Modul02
{
    public class TaschenrechnerModel : PageModel
    {
        [BindProperty()]
        public float input1 { get; set; }
        [BindProperty()]
        public float input2 { get; set; }

        public double Ausgabe;

        public void OnGet()
        {
        }
        
        public void OnPostAdd() {


            Ausgabe=input1 + input2;
        }
        public void OnPostSub()
        {


            Ausgabe = input1 - input2;
        }

    }
}
