using DataAccessLayer.Context;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class LoginController : Controller
    {
        [HttpPost]
        public ActionResult Index(string AdminUserName, string AdminPassword)
        {
            DataBaseContext dataBaseContext = new DataBaseContext();
            // Kullanıcının kimliğini doğrula
            var user = dataBaseContext.Admins.SingleOrDefault(u => u.AdminUserName == AdminUserName && u.AdminPassword == AdminPassword);
            if (user == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                // Kullanıcı bulundu, rol bilgisini sakla
                ViewBag.AdminRole = user.AdminRole;
                return View("MainMenu", user.AdminRole);
                //return RedirectToAction("Index", "MainMenu");
            }
        }
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Index(Admin admin)
        //{
        //    DataBaseContext dataBaseContext = new DataBaseContext();
        //    var adminuserinfo = dataBaseContext.Admins.FirstOrDefault(x => x.AdminUserName == admin.AdminUserName && x.AdminPassword == admin.AdminPassword);
        //    if (adminuserinfo != null)
        //    {     
        //        return RedirectToAction("Index", "MainMenu");
        //    }
        //    else
        //    {
        //        return RedirectToAction("Index");
        //    }

        //}
    }
}
