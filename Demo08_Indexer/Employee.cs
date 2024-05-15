using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Indexer
{
    internal class Employee
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        // Property Initializer Expression
        public string Designation { get; set; } = string.Empty;
    }
}
