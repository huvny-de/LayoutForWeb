using Microsoft.AspNetCore.Mvc;

namespace LayoutForWeb.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
