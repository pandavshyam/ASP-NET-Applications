using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.ViewModel
{
    public class StudentViewModel
    {
        public Student Student { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }
    }
}