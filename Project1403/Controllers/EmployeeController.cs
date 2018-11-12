using Project1403.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1403.Controllers
{
    public class EmployeeController : Controller
    {
        public static List<Employee> empList = new List<Employee>();

        // GET: Employee
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee employee)
        {
            if (ModelState.IsValid)
            {
                
                return View("clock", employee);
            }
            else
            {
                return View("Index");
            }
        }

        public ActionResult displayEmployees()
        {
            ViewBag.Display = empList;
            return View();
        }

        [HttpPost]
        public ActionResult clock(Employee employee, string status)
        {
            if (status == "IN")
            {
                employee.timeIN = DateTime.Now;
                ViewBag.status = "Thank You " + employee.firstName + "You have been clocked in.";
            }
            else
            {
                employee.timeOUT = DateTime.Now;
                ViewBag.status = "Thank You " + employee.firstName + "You have been clocked out.";
            }
            empList.Add(employee);
           
            return View();
        }
    }
}