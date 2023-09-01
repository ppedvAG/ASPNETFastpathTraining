using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
namespace ASPNETFastpathTraining.Pages.Modul05
{
    public class TextEditModel : PageModel
    {
        private readonly string Pfad=Path.Combine(Directory.GetCurrentDirectory(),"App_data","mailtemplates");
        public List<string> Liste { get; set; }
        [BindProperty(SupportsGet =true)]
        public string fileName { get; set; }
        public String fileContent { get; set; }
        public void OnGet()
        {
            //LINQ

            Liste = Directory.GetFiles(Pfad, "*.txt").Select(Path.GetFileName).ToList();
            if (!string.IsNullOrEmpty(fileName))
            {

                fileContent=System.IO.File.ReadAllText(Path.Combine(Pfad,fileName));
            }

        }
    }
}
