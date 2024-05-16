using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09_Constructors
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Property Initialization Expression during declaration
        public string CompanyName { get; set; } = string.Empty;

        // INSTANCE CONSTRUCTOR
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;

            // Initialize the INSTANCE member over here
            // OR use Property Initialization Expression during declaration.
            // CompanyName = string.Empty;
        }

        // TYPE MEMBER
        // Property Initialization Expression during declaration
        public static string Location { get; set; } // = string.Empty;

        // TYPE CONSTRUCTOR
        static Employee()
        {
            // Initialize the TYPE member over here
            // OR use Property Initialization Expression during declaration.
            Employee.Location = string.Empty;
        }

    }
}
