using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class DeptEmpCount
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
    class ListDeptEmpCount
    {
        static void Main(string[] args)
        {
            var ctx = new HRContext();

            var depts = ctx.Database.SqlQuery<DeptEmpCount>
                ("select d.name as Name, count(*) as Count from employees as e join departments as d on (e.Department_Id = d.id) group by d.name");

            // List all Departments with Employees 
            foreach (var dept in depts)
            {
                Console.WriteLine($"{dept.Name.PadRight(20)}  {dept.Count}");
            }
        }
    }
}
