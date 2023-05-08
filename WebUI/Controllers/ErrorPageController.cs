using Azure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFrameworkProjem.Controllers
{
    public class ErrorPageController : Controller
    {
        [Route("Error/404")]
        public IActionResult Error404()
        {
            return View("~/Views/ErrorPage/Page404.cshtml");
        }
    }
}