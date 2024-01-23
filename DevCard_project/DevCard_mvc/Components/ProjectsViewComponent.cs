using Microsoft.AspNetCore.Mvc;
namespace DevCard_mvc.Components
{
    public class ProjectsViewComponent: ViewComponent
    {
        public IViewComponentResult invoke()
        { 
        return View("_Projects");
        }
        
    }
}
