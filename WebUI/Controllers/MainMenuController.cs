using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class MainMenuController : Controller
    {
       
        public IActionResult Index()
        {

            return View();
        }

    }
}
