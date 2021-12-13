using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserAPP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        
        {
            //return View("User");
            return RedirectToAction("Index", "User");
        }
    }
}