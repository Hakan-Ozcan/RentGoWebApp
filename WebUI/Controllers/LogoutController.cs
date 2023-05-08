using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class LogoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
