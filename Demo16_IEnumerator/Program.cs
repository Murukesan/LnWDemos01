namespace Demo16_IEnumerator
{
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

            Console.WriteLine("--- Using IEnumerator");
            objCompany.Reset();
            while(objCompany.MoveNext())
            {
                Employee? emp = objCompany.Current as Employee;     // unbox before consumption
                //if(emp != null)
                //{
                //    Console.WriteLine("ID : {0}, Name: {1}", emp.EmployeeID, emp.EmployeeName);
                //}
                Console.WriteLine("ID : {0}, Name: {1}", emp?.EmployeeID, emp?.EmployeeName);
            }
        }
    }
}
