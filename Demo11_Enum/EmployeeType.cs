using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11_Enum
{
    internal enum EmployeeType
    {
        PartTimeEmployee,
        FullTimeEmployee,
        ExEmployee
    }

    internal enum Positions
    {
        First,                  // First = 0
        Second,                 // Second = 1
        Third                   // Third = 2
    }    

    // Alias to the enumeration member
    internal enum Positions2
    {
        First = 1, One = 1, Uno = 1,
        Second = 2, Two = 2, Duo = 2,
        // Two = 2, Duo = 2, Second = 2, 
        Third = 3, Three = 3, Tri = 3
    }

    // all members in the enumeration are alphabetically sorted.
    internal enum Positions3
    {
        Duo = 2,
        First = 1,
        One = 1,
        Second = 2,
        Third = 3,
        Three = 3,
        Tri = 3,
        Two = 2,
        Uno = 1
    }
}
