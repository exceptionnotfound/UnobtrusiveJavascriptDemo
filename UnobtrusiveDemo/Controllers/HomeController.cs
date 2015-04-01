using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnobtrusiveDemo.ViewModels.Home;

namespace UnobtrusiveDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ServerSide()
        {
            AddUserVM model = new AddUserVM();
            return View(model);
        }

        [HttpPost]
        public ActionResult ServerSide(AddUserVM model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Unobtrusive()
        {
            AddUserVM model = new AddUserVM();
            return View(model);
        }

        [HttpPost]
        public ActionResult Unobtrusive(AddUserVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Index");
        }
    }
}