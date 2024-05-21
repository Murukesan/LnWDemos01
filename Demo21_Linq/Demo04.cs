using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo21_Linq.Demo04
{
    // Anonymous Type
    internal class Demo
    {
        static internal void RunThis()
        {
            // object of the known type - separate intializers to initialize the properties
            Employee emp1 = new Employee();
            emp1.Id = 5;
            emp1.Name = "Some employee";
            Console.WriteLine($"{emp1.Id} {emp1.Name}");
            Console.WriteLine($"{emp1.GetType()}");
            Console.WriteLine();

            // Object of the Known Type - Object Initializers
            Employee emp2 
                = new Employee() 
                { 
                    Id = 10, 
                    Name = "First Employee" 
                };
            Console.WriteLine($"{emp2.Id} {emp2.Name}");
            Console.WriteLine($"{emp2.GetType()}");
            Console.WriteLine();

            // ANONYMOUS TYPE - Type would be inferred during the initialization
            //                  & type would be generated during compilation
            var emp3 = new { Id = 100, Name = "Anonymous Employee" };
            Console.WriteLine($"{emp3.Id} {emp3.Name}");
            Console.WriteLine($"{emp3.GetType()}");
            Console.WriteLine();

            var emp4 = new { Id = 200, Name = "Anonymous Employee 2" };
            Console.WriteLine($"{emp4.Id} {emp4.Name}");
            Console.WriteLine($"{emp4.GetType()}");
            Console.WriteLine();

            Console.WriteLine("--------------");

            // POSITION of the Property Members in the Object Initializer

            var emp5 = new Employee() { Name = "Second Employee", Id = 20 };
            Console.WriteLine($"{emp5.Id} {emp4.Name}");
            Console.WriteLine($"{emp5.GetType()}");
            Console.WriteLine();

            var emp6 = new { Name = "Anonymous Employee 3", Id = 300 };
            Console.WriteLine($"{emp6.Id} {emp6.Name}");
            Console.WriteLine($"{emp6.GetType()}");
            Console.WriteLine();

            Console.WriteLine("--------------");

            // NAME of the Property Members in the Object Initializer

            var emp7 = new { FullName = "Anonymous Employee 3", Id = 300 };
            Console.WriteLine($"{emp7.Id} {emp7.FullName}");
            Console.WriteLine($"{emp7.GetType()}");
            Console.WriteLine();

            // Anonymous Properties are READONLY 
            // emp7.FullName = emp7.FullName.ToUpper();
        }
    }

    // Known Type
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
