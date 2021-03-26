using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTfulAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }


        public List<Employee> GetEMps()
        {
            List<Employee> emps = new List<Employee>();
            emps.Add(new Employee() { Id = 10, Name = "Sachin", Adress = "Mumbai" });
            emps.Add(new Employee() { Id = 11, Name = "Virat", Adress = "Delhi" });
            emps.Add(new Employee() { Id = 12, Name = "Ajinkya", Adress = "Pune" });

            return emps;
        }
    }
}