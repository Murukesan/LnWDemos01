namespace Demo17_IEnumerable
{
    //     1. How to use IEnumerable 
    //     2. How FOREACH works
    //     3. How to work Custom Collections (Company has aggregated collection of Employees)
    //     4. How to use IList<Employee>
    internal class Program
    {
        static void Main(string[] args)
        {
            Company objCompany = new Company("Microsoft");

            objCompany.AddEmployee("First Employee");
            objCompany.AddEmployee("Second Employee");
            objCompany.AddEmployee("Third Employee");
            objCompany.AddEmployee("Fourth Employee");
            objCompany.AddEmployee("Fifth Employee");

            objCompany.DisplayInformation();
            Console.WriteLine();

            /********************
            Console.WriteLine("--- Using IEnumerator");
            objCompany.Reset();
            while (objCompany.MoveNext())
            {
                Employee? emp = objCompany.Current as Employee;     // unbox before consumption
                //if(emp != null)
                //{
                //    Console.WriteLine("ID : {0}, Name: {1}", emp.EmployeeID, emp.EmployeeName);
                //}
                Console.WriteLine("ID : {0}, Name: {1}", emp?.EmployeeID, emp?.EmployeeName);
            }
            *****************************/

            Console.WriteLine("---- using IEnumerable");             // Readonly Forwardonly iteration!
            Company objCompany2 = new Company("IBM");
            foreach(Employee emp in objCompany2)     // implicitly calls GetEnumerator() => IEnumerator()
            {
                // implicitly typecasts the object if available and offers it to the loop!
                Console.WriteLine("ID : {0}, Name: {1}", emp.EmployeeID, emp.EmployeeName);
            }

            Console.WriteLine();

            Employee? empSecondEmployee = objCompany[2];
            if(empSecondEmployee != null)
            {
                Console.WriteLine("Found: {0}", empSecondEmployee);
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
    }
}

