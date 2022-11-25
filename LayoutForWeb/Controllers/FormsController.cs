using Microsoft.AspNetCore.Mvc;

namespace LayoutForWeb.Controllers
{
    public class FormsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
