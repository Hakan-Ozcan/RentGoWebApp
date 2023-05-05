using DataAccessLayer.Context;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Admin admin)
        {
            DataBaseContext dataBaseContext = new DataBaseContext();
            var adminuserinfo = dataBaseContext.Admins.FirstOrDefault(x => x.AdminUserName == admin.AdminUserName && x.AdminPassword == admin.AdminPassword);
            if (adminuserinfo != null)
            {     
                return RedirectToAction("Index", "MainMenu");
            }
            else
            {
                return RedirectToAction("Index");
            }

        }
    }
}
