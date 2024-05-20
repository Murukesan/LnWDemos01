using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo17_IEnumerable
{
    internal class Employee
    {
        public readonly int EmployeeID;
        public string EmployeeName { get; set; }

        public Employee(int employeeID, string employeeName)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.EmployeeID, this.EmployeeName);
        }
    }
}
