using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignments
{
    /*
     * Define Employee class containing following members :-

        Auto Implemented Properties :

        EmpId, Name, DeptId, Salary

        Method :

        override ToString() to return employee details
    */
    class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int DeptId { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            string output = "EmpId : " + this.EmpId + "  Name : " + this.Name + "  deptId : " + this.DeptId + "  Salary : " + this.Salary;
            return output;
        }
    }
    class Problem2
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { EmpId = 1, Name = "Shyam", DeptId = 10, Salary = 30000 };
            Console.WriteLine(emp.ToString());
        }
    }
}
