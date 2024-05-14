namespace Demo05_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo of ReferenceType");

            // Reference Type
            Employee emp;                   // Declaration of object
            emp = new Employee();           // EXPLICIT Instantiation of object (LATE INSTANTIATION)
            emp.Id = 100;                   // Initialization of member of object
            emp.Name = "First Employee";    // Initialization of member of object
            Console.WriteLine($"ID: {emp.Id} Name: {emp.Name}");


            // Declaration, Instantiation, Initialization
            Employee emp2 = new Employee() { Id = 200, Name = "Second Employee" };
            Console.WriteLine($"ID: {emp2.Id} Name: {emp2.Name}");


            Employee[] arrEmp = new Employee[3];
            arrEmp[0] = new Employee();             // explicit instantiate
            arrEmp[0].Id = 10;
            arrEmp[0].Name = "First Employee";
            arrEmp[1] = new Employee();             // explicit instantiate
            arrEmp[1].Id = 20;
            arrEmp[1].Name = "Second Employee";
            arrEmp[2] = new Employee();             // explicit instantiate
            arrEmp[2].Id = 30;
            arrEmp[2].Name = "Third Employee";

            Employee[] arrEmp2 = new Employee[2]
            {
                new Employee() { Id = 10, Name = "First Employee" },      // Object Initialization
                new Employee() { Id = 20, Name = "Second Employee" }      // Object Initialization
            };
            Employee[] arrEmp3 =
            {
                new Employee { Id = 10, Name = "First Employee" },      // Object Initialization
                new Employee { Id = 20, Name = "Second Employee" }      // Object Initialization
            };

        }
    }
}
