using Microsoft.AspNetCore.Mvc;

namespace LayoutForWeb.Controllers
{
    public class TablesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
