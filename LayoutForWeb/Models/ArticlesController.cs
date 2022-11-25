using Microsoft.AspNetCore.Mvc;

namespace LayoutForWeb.Models
{
    public class ArticlesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
