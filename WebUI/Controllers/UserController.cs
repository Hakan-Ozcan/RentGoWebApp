using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using DataAccessLayer.EntityFramework;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class UserController : Controller
    {
        UserManager userManager = new UserManager(new EfUserDal());
    
        public IActionResult Index()
        {
            var usersvalues = userManager.GetList();
            return View(usersvalues);

        }
        public IActionResult GetUserById(int id)
        {

            var usersvalues = userManager.GetByID(id);
            return View(usersvalues);

        }

    
        [HttpGet]
        public IActionResult AddUser()
        {
          return View();
        }
        public int GetLastUserId()
        {
            return userManager.GetList().OrderByDescending(u => u.ID).FirstOrDefault()?.ID ?? 0;
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            userManager.UserAdd(user);

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult UpdateUser(User user)
        {
            if (user != null)
            {
                userManager.UserUpdate(user);
            }
            return View();
        }
    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteUser(User user)
        {
            userManager.UserDelete(user);
            return RedirectToAction(nameof(Index));
        }


    }
}
