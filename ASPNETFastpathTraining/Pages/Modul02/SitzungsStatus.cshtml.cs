using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETFastpathTraining.Pages.Modul02
{
    public class SitzungsStatusModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost() {
            HttpContext.Session.SetString("hannes", Request.Form["input1"]);
            Response.Redirect("/session2");
        }
    }
}
