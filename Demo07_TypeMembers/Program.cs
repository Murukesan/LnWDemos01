namespace Demo07_TypeMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeClass employee = new EmployeeClass();
            employee.EmployeeId = 1;
            // employee.EmployeeName = "";
            employee.SetEmployeeName("Manoj");
            Console.WriteLine("ID: {0}, Name: {1}", 
                employee.EmployeeId, employee.GetEmployeeName());
            Console.WriteLine();

            Console.WriteLine("--- concatinating the LastName");
            // employee.EmployeeName = employee.EmployeeName + " SHARMA";
            employee.SetEmployeeName( employee.GetEmployeeName() + " SHARMA" );

            Console.WriteLine("ID: {0}, Name: {1}",
                employee.EmployeeId, employee.GetEmployeeName());
            Console.WriteLine();

            employee.Designation = "CEO";                       // calls the SET ACCESSOR
            Console.WriteLine(employee.Designation);            // calls the GET ACCESSOR


            // employee.Designation = employee.Designation + " of the company";
            employee.Designation += " of the company";          // GET, SET

            
            //EmployeeClass emp1, emp2;
            //emp1 = new EmployeeClass();
            //emp1.EmployeeId = 10;
            //emp2 = new EmployeeClass();
            //emp2.EmployeeId = -5;
        }



    }
}
