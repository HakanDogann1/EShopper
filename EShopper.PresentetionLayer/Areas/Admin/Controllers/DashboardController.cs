using Microsoft.AspNetCore.Mvc;

namespace EShopper.PresentetionLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeadPartialView()
        {
            return PartialView();
        }
    }
}
