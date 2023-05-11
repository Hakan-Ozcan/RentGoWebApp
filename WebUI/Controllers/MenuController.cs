using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class MenuController : Controller
    {
        MenuManager menuManager = new MenuManager(new EfMenuDal());

        public IActionResult Index()
        {    
            var menuvalues = menuManager.MenuList();
            return View(menuvalues);
        }
        public IActionResult GetMenuById(int id)
        {

            var usersvalues = menuManager.GetByID(id);
            return View(usersvalues);

        }


        [HttpGet]
        public IActionResult AddMenu()
        {
            return View();
        }
        public int GetLastMenuId()
        {
            return menuManager.MenuList().OrderByDescending(u => u.ID).FirstOrDefault()?.ID ?? 0;
        }

        [HttpPost]
        public IActionResult AddMenu(Menu menu)
        {
            menuManager.MenuAdd(menu);

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult UpdateMenu(Menu menu)
        {
            if (menu != null)
            {
                menuManager.MenuUpdate(menu);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteMenu(Menu menu)
        {
            menuManager.MenuDelete(menu);
            return RedirectToAction(nameof(Index));
        }

    }
}
