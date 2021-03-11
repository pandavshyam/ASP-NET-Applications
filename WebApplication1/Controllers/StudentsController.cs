using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class StudentsController : Controller
    {
        // GET: GetStudents
        public ActionResult GetStudents()
        {
            //List<Student> studentList = new List<Student>() 
            //{ 
            //    new Student()
            //    {
            //        ID = 1,
            //        Name = "Pratik",
            //        Address = "Nashik"
            //    },
            //    new Student()
            //    {
            //        ID = 2,
            //        Name = "Kunal",
            //        Address = "Solapur"
            //    },
            //    new Student()
            //    {
            //        ID = 3,
            //        Name = "Nishad",
            //        Address = "Nashik"
            //    }
            //};

            Student student = new Student()
            {
                ID = 1,
                Name = "Shyam Pandav",
                Address = "Pune"
            };

            List<Subject> subjects = new List<Subject>()
            {
                new Subject(){ ID = 1, Name = "Computer Programming"},
                new Subject(){ ID = 2, Name = "DBMS"}
            };

            StudentViewModel studentViewModel = new StudentViewModel()
            {
                Student = student,
                Subjects = subjects
            };

            return View(studentViewModel);
        }

        public ActionResult TestParameter(int id)
        {
            return Content("Input is " + id);
        }
    }
}