using Project1403.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1403.Controllers
{
    public class AdminController : Controller
    {
        public static List<Project> listProjects = new List<Project>();
        public static List<SubContractor> listSubs = new List<SubContractor>();
        int projID = 0;

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Admin()
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

        [HttpPost]
        public ActionResult Project(Project oProj)
        {
            oProj.projectID = projID++;
            listProjects.Add(oProj);
            return View();
        }

        public ActionResult ProjectList()
        {
            return View(listProjects);
        }

        public ActionResult SubContractor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubContractor(SubContractor oSub)
        {
            listSubs.Add(oSub);
            return View();
        }

        public ActionResult SubContractorList()
        {
            return View(listSubs);
        }
    }
}