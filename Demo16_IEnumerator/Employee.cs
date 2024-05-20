using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo16_IEnumerator
{
    internal class Employee
    {
        public int EmployeeID { get; private set; }

        public string EmployeeName { get; set; }

        public Employee(int id, string name)
        {
            EmployeeID = id;
            EmployeeName = name;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.EmployeeID, this.EmployeeName); 
        }
    }
}
