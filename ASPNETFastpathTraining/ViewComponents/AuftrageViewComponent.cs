using ASPNETFastpathTraining.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETFastpathTraining.ViewComponents
{
    public class AuftrageViewComponent: ViewComponent
    {
        
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
           
            return View(id);
            //Views/Shared/Components/{View Component Name}/{View Name
        }
    }
}
