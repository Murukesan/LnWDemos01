namespace Demo19_Event_INotifyPropertyChanged
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo01();

            Console.WriteLine("======================================");

            Demo02();
        }

        private static void Demo02()
        {
            Employee emp = new Employee();

            emp.Id = 50;
            emp.Name = "Second Employee";

            Console.WriteLine("---- BEFORE: ID: {0} Name: {1}", emp.Id, emp.Name);
            Console.WriteLine();

            // Subscribe to the Event
            emp.PropertyChanged
                += new System.ComponentModel.PropertyChangedEventHandler(EmployeeChanged);

            DoSomethingWithEmployee(emp);

            Console.WriteLine("---- ON EXIT ID: {0} Name: {1}", emp.Id, emp.Name);
            Console.WriteLine();
        }

        private static void Demo01()
        {
            Employee emp = new Employee();

            emp.Id = 10;
            emp.Name = "First Employee";

            Console.WriteLine("---- BEFORE: ID: {0} Name: {1}", emp.Id, emp.Name);
            Console.WriteLine();

            Console.WriteLine("--- without event registration");
            DoSomethingWithEmployee(emp);
            Console.WriteLine();

            Console.WriteLine("---- ON EXIT ID: {0} Name: {1}", emp.Id, emp.Name);
            Console.WriteLine();
        }

        static void EmployeeChanged(
            object? sender, 
            System.ComponentModel.PropertyChangedEventArgs e)
        {
            Console.WriteLine("SOMETHING CHANGED!");
            Console.WriteLine("\t {0}", e.PropertyName);
        }

        static void DoSomethingWithEmployee(Employee emp)
        {
            Console.WriteLine("RECEIVED - ID: {0}, Name: {1}", emp.Id, emp.Name);

            emp.Name = "Something Other Name";

            Console.WriteLine("AFTER CHANGE - ID: {0}, Name: {1}", emp.Id, emp.Name);
        }
    }
}
