using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class ErrorPageController : Controller
    {
        // GET: ErrorPage
        public IActionResult Index()
        {
            return View();
        }
    }
}
