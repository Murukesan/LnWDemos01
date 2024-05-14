namespace Demo04_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo of ValueType");
            // Custom Value Types
            Employee emp;                   // Declaration (IMPLICIT Instantiation)
            emp.Id = 100;                   // Initialization of member of object
            emp.Name = "First Employee";    // Initialization of member of object
            Console.WriteLine($"ID: {emp.Id} Name: {emp.Name}");

            int i = 10;

            // Declaration, Instantiation, Initialization
            Employee emp2 = new Employee() { Id = 200, Name = "Second Employee" };
            Console.WriteLine($"ID: {emp2.Id} Name: {emp2.Name}");


            int[] arrInt;                   // Declaration
            arrInt = new int[5];            // Instantation
            arrInt[0] = 10;                 // Initialization
            arrInt[1] = 20;
            arrInt[2] = 30;
            arrInt[3] = 40;
            arrInt[4] = 50;

            // Declaration, Instantiation, Initialization
            int[] arrInt2 = new int[5] { 10, 20, 30, 40, 50 };
            int[] arrInt3 = { 10, 20, 30, 40, 50 };

            int[,] arr2Int2 = new int[2, 3];
            arr2Int2[0, 0] = 10;
            arr2Int2[0, 1] = 10;
            arr2Int2[0, 2] = 10;
            arr2Int2[1, 0] = 10;
            arr2Int2[1, 1] = 10;
            arr2Int2[1, 2] = 10;

            int[,] arr2dInt =
            {
                {10, 20, 30},
                {40, 50, 60}
            };


            Employee[] arrEmp = new Employee[3];
            arrEmp[0].Id = 10;
            arrEmp[0].Name = "First Employee";
            arrEmp[1].Id = 20;
            arrEmp[1].Name = "Second Employee";
            arrEmp[2].Id = 30;
            arrEmp[2].Name = "Third Employee";

            Employee[] arrEmp2 = new Employee[2]
            {
                new Employee { Id = 10, Name = "First Employee" },      // Object Initialization
                new Employee { Id = 20, Name = "Second Employee" }      // Object Initialization
            };
            Employee[] arrEmp3 = 
            {
                new Employee { Id = 10, Name = "First Employee" },      // Object Initialization
                new Employee { Id = 20, Name = "Second Employee" }      // Object Initialization
            };
        }
    }
}
