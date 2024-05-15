using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07_TypeMembers
{
    internal class Employee
    {
        #region Instance Members 

        public readonly int EmployeeID;         // readonly data-field

        private string? _employeeName;          // backing data-field
        public string? EmployeeName             // manually-implemented property
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }

        // Auto-Implemented Property
        public string? Designation { get; set; }

        public void Work()
        {
            Console.WriteLine("Employee {0} is working today", this.EmployeeID);
            Console.WriteLine("working in the company: {0}", Employee.CompanyName);
        }

        #endregion


        #region Type Member (shared amongst all objects of the current type)

        public static string CompanyName { get; set; } = "Microsoft";

        #endregion


        // Instance Constructor
        // -- can have scope (Private, Public, Protected, Internal, Protected Internal)
        // -- can have parameters
        public Employee()
        {
            this.EmployeeID = 0;
            this.EmployeeName = string.Empty;
            this.Designation = string.Empty;
        }

        public Employee(int id, string name)
        {
            this.EmployeeID = id;
            this.EmployeeName = name;
            this.Designation = string.Empty;
        }

        // Type Constructor
        // -- always PUBLIC
        // -- cannot have any parameters
        static Employee()
        {
            Employee.CompanyName = "Microsoft";
        }
    }
}
