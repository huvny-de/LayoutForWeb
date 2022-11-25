using Microsoft.AspNetCore.Mvc;

namespace LayoutForWeb.Controllers
{
    public class EcommerceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
