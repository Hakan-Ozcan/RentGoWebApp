using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using DataAccessLayer.EntityFramework;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebUI.Controllers
{
    public class ProgramsController : Controller
    {
        ProgramsManager programsManager = new ProgramsManager(new EfProgramsDal());
        public IActionResult Index()
        {
            var model = programsManager.GetList();    
            return View(model);
        }
        public IActionResult Ekle()
        {
            return View();
        }
    
       [HttpPost]
       [ValidateAntiForgeryToken]
        public IActionResult Ekle([Bind("ID,ProgramName")] Programs programs)
        {
            if (ModelState.IsValid)
            {

                programsManager.ProgramsAdd(programs);
            }
            return View(programs);
        }



    }
}
