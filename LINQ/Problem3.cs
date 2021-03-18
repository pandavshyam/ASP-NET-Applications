using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignments
{
    /*
     * Create a list of 12 to 15 Employees & perform the following operations on list

        a) print sorted list of employees based on empId/empName (OrderBy)

        b) Check whether all employees are having Salary more than 15000 (All)

        c) Check whether any employee is having Salary more than 45000 (Any)

        d) List distinct (empId based) Employees [add employees having duplicate empId in collection to test function] (Distinct)

        e) List of Employees having deptId=3 (Where)

        [Optional: Can also use Sum, Take, TakeWhile, ToDictionary etc]
    */
    class Problem3
    {
        static void Main(string[] args)
        {
            List<Employee> AllEmployees = new List<Employee>()
            {   new Employee(){EmpId=1, Name="Shyam",DeptId=10, Salary=10000.00 },
                new Employee(){EmpId=1, Name="Avinash",DeptId=10, Salary=15000.00 },
                new Employee(){EmpId=2, Name="Yaman",DeptId=10, Salary=15000.00 },
                new Employee(){EmpId=11, Name="Prajyot",DeptId=3, Salary=20000.00 },
                new Employee(){EmpId=3, Name="Sushama",DeptId=10, Salary=10000.00 },
                new Employee(){EmpId=10, Name="Tanuja",DeptId=3, Salary=10000.00 },
                new Employee(){EmpId=4, Name="Bonish",DeptId=10, Salary=12000.00 },
                new Employee(){EmpId=9, Name="Pratik",DeptId=3, Salary=12000.00 },
                new Employee(){EmpId=5, Name="Kunal",DeptId=6, Salary=10000.00 }
            };

            var SortById = from p in AllEmployees
                           orderby p.EmpId
                           select p;
            foreach (var em in SortById)
                Console.WriteLine(em);

            bool CheckAll = AllEmployees.All(e => e.Salary > 15000);
            if (CheckAll == true)
                Console.WriteLine("All employees have salary greater than 15000");

            bool CheckAny = AllEmployees.Any(e => e.Salary > 45000);
            if (CheckAny == true)
                Console.WriteLine("Some employees have salary > 45000");

            var DistinctEmp = AllEmployees.Distinct();
            foreach (var em in DistinctEmp)
                Console.WriteLine(em);

            var DeptID3 = AllEmployees.Where(x => x.DeptId == 3);

            foreach (var em in DeptID3)
                Console.WriteLine(em);
        }
    }
}
