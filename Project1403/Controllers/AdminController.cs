using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1403.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            if(ModelState.IsValid)
            {
                return View("Admin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Project()
        {
            return View();
        }

        public ActionResult SubContractor()
        {
            return View();
        }
    }
}