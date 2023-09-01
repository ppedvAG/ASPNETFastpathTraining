using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETFastpathTraining.Pages.Modul02
{
    public class IndexModel : PageModel
    {
        public string Variable = "Tets";
        public void OnGet()
        {


        }
        public void OnPost() {
         Variable=   Request.Form["input1"];
        }    
    }
}
