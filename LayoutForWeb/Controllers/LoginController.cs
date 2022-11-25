using Microsoft.AspNetCore.Mvc;

namespace LayoutForWeb.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
