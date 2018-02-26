using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace MVCDemos.Controllers
{
    using MVCDemos.Models;
    using MVCDemos.Repositories;

    public class HomeController : Controller
    {
        private IUserRepository repo;

        public HomeController()
        {
            repo = new UserRepository();
        }
        // GET: Home
        public ActionResult Index()
        {
         
            return View(repo.Get_All_Users());
        }


        [HttpPost]
        public ActionResult Index(User u)
        {
            return View(u);
        }
    }
}