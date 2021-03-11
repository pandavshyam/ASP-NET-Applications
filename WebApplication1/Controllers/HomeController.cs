using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Name = "Shyam Pandav";
            ViewBag.College = "MIT";
            return View();
        }

        public ActionResult GetEmployer()
        {
            List<Employee> listOfEmployee = new List<Employee>() 
            { 
                new Employee()
                {
                    EmployeeID = 1,
                    EmployeeName = "Shyam Pandav",
                    Address = "Pune",
                    DateOfJoining = DateTime.Today,
                    Salary = 50000
                },
                new Employee()
                {
                    EmployeeID = 2,
                    EmployeeName = "Avinash Kumar",
                    Address = "Pune",
                    DateOfJoining = DateTime.Today,
                    Salary = 60000
                },
                new Employee()
                {
                    EmployeeID = 3,
                    EmployeeName = "Prajyot Chinchane",
                    Address = "Mumbai",
                    DateOfJoining = DateTime.Today,
                    Salary = 55000
                },
                new Employee()
                {
                    EmployeeID = 4,
                    EmployeeName = "Yaman Lamba",
                    Address = "Pune",
                    DateOfJoining = DateTime.Today,
                    Salary = 65000
                },
            };

            ViewBag.Employees = listOfEmployee;
            return View();
        }
   
    }
}