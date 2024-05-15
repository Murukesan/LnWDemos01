namespace Demo08_Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demo01();

            // Demo02();

            //Company company = new Company();
            //company.CompanyName = "Microsoft";


            // using the Default Construtor
            Company company = new Company() { CompanyName = "Microsoft" };
            company.AddEmployee(
                new Employee()
                {
                    Id = 1,
                    Name = "First Employee",
                    Designation = "President"
                });
            company.AddEmployee( new Employee() {
                    Id = 2,
                    Name = "Second Employee",
                    Designation = "Manager"
                });
            company.DisplayInfo();

            Employee? empFind = company["Somebody"];    // invokes the GET accessor of Indexer
            if(empFind is not null)
            {
                Console.WriteLine("Employee found! {0} {1}", empFind.Id, empFind.Name);
            }
            else
            {
                Console.WriteLine("Employee not found!");
            }
            Console.WriteLine("------------------------");

            // using the Parameterized Constructor
            Company company2 = new Company("L and W");
            company2.DisplayInfo();

            Company company3 = new Company(
                "Apple",
                new Employee() { Id = 1, Name = "Steve Jobs", Designation = "CEO" });
            company3.DisplayInfo();

            Company company4 = new Company(
                "Apple", 
                new Employee[] {
                    new Employee() { Id = 1, Name = "Steve Jobs", Designation = "CEO" },
                    new Employee() { Id = 2, Name = "Steve Jobs", Designation = "CEO" },
                    new Employee() { Id = 3, Name = "Steve Jobs", Designation = "CEO" }
                });
            company4.DisplayInfo();
        }

        /// <summary>
        ///     Demo of how to work with an Array
        /// </summary>
        private static void Demo02()
        {

            // Arrays are always fixed-length (cannot be resized)
            int[] arrInt = { 1, 2, 3, 5, 7 };
            // arrInt.Length = 20;


            Employee[] employees = new Employee[3];     // declaration
            employees[0] = new Employee();
            employees[0].Id = 10;
            employees[0].Name = "First Employee";
            employees[0].Designation = "CEO";

            // Object Initializer
            employees[1] = new Employee()       // instantiation
            {
                Id = 2,                     // initialization
                Name = "Second Employee",   // initialization
                Designation = "Manager"     // initialization
            };
        }

        /// <summary>
        ///     Demo of how to work with an object
        /// </summary>
        private static void Demo01()
        {
            Employee emp = new Employee();
            emp.Id = 1;
            emp.Name = "First Employee";
            emp.Designation = "CEO";
        }
    }
}
