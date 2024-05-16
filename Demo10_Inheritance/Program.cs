namespace Demo10_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo01();

        }

        private static void Demo01()
        {
            MyBase objBase = new MyBase();

            // overload
            Console.WriteLine("--- objBase.Add(10, 20)");
            objBase.Add(10, 20);
            Console.WriteLine("--- objBase.Add(20, 30, 40)");
            objBase.Add(20, 30, 40);

            Console.WriteLine();

            MyDerived objDerived = new MyDerived();
            Console.WriteLine("--- objDerived.Add(100, 200);");
            objDerived.Add(100, 200);
            Console.WriteLine("--- objDerived.Add(100, 200, 300);");
            objDerived.Add(100, 200, 300);
            Console.WriteLine("--- objDerived.Add(100, 200, 300, 400);");
            objDerived.Add(100, 200, 300, 400);

            Console.WriteLine();

            MyBase objBase2 = new MyDerived();
            Console.WriteLine("--- objBase2.Add(10, 20)");
            objBase2.Add(10, 20);
            Console.WriteLine("--- objBase2.Add(20, 30, 40)");
            objBase2.Add(20, 30, 40);
            // Console.WriteLine("--- objDerived.Add(100, 200, 300, 400);");
            // objBase2.Add(100, 200, 300, 400);

            Console.WriteLine();

            Console.WriteLine("--- objBase.ShowInfo();");
            objBase.ShowInfo();         // MyBase objBase = new MyBase();
            Console.WriteLine("--- objDerived.ShowInfo();");
            objDerived.ShowInfo();      // MyDerived objDerived = new MyDerived();

            // INHERITANCE IS TOP-DOWN, EXECUTION IS BOTTOM-UP
            Console.WriteLine("--- objBase2.ShowInfo();");
            objBase2.ShowInfo();        // MyBase objBase2 = new MyDerived();

            Console.WriteLine();

            objBase2.Add();
        }
    }
}
