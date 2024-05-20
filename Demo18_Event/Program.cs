namespace Demo18_Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crashes the application
            // Demo01.Process objProcess = new Demo01.Process();
            // objProcess.DoSomething();

            // demo of Delegate
            // Demo02.Process objProcess2 = new Demo02.Process();
            // objProcess2.DoSomething(Program.SomethingWentWrong);

            // demo showing Dependency Injection Pattern
            // Demo03.Process objProcess3 = new Demo03.Process(Program.SomethingWentWrong);
            // objProcess3.DoSomething();

            //Console.WriteLine("--- without event subscription");
            //Demo04.Process objProcess4 = new Demo04.Process();
            //objProcess4.DoSomething();

            Console.WriteLine();

            // Demo of OBSERVER PATTERN
            Console.WriteLine("--- with event subscription");
            Demo04.Process objProcess4b = new Demo04.Process();
            objProcess4b.OnProcessFailure += Program.SomethingWentWrong;     // event subscription
            objProcess4b.DoSomething();
        }

        static void SomethingWentWrong(string message)
        {
            Console.WriteLine(message);
        }
    }
}
