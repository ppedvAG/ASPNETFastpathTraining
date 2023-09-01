using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETFastpathTraining.Pages.Modul05
{

    public class PLZModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient client;

        public List<PLZ> Liste { get; set; }

        public PLZModel(IConfiguration _config, IHttpClientFactory _http)
        {
            _configuration = _config;
           
           client= _http.CreateClient();
        }
        public void OnGet()
        {
        }
        public async Task OnPostAsync(string suche) {
            //https://openplzapi.org/de/Localities?postalCode=8448
            var url = $"{_configuration["ApiPLZUrl"]}/Localities?postalCode={suche}";
            Liste= await client.GetFromJsonAsync<List<PLZ>>(url);
        
        }
    }
}
