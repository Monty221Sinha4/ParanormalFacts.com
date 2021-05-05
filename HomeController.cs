using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParanormalFacts.com.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Werewolf()
        {
            return View();
        }
        public ActionResult Vampires()
        {
            return View();
        }
        public ActionResult UFOs()
        {
            return View();
        }

    }
}