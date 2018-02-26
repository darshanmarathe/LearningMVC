using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace MVCDemos.Controllers
{
    using MVCDemos.Models;

    public class HomeController : Controller
    {


        // GET: Home
        public ActionResult Index()
        {
            var u = new User();

            u.UserName = "darshan";
            u.FirstName = "darshan";
            u.LastName = "Marathe";

            return View(u);
        }


        [HttpPost]
        public ActionResult Index(User u)
        {
            return View(u);
        }
    }
}