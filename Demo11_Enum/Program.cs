namespace Demo11_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string COMPANYNAME = "L and D";

            EmployeeType pt = EmployeeType.PartTimeEmployee;

            Console.WriteLine(COMPANYNAME);

            Console.WriteLine(pt);
            pt = EmployeeType.FullTimeEmployee;
            Console.WriteLine(pt);

            Console.WriteLine();

            Positions p = Positions.Second;
            Console.WriteLine(p);           // Second
            Console.WriteLine((int)p);      // 1

            Console.WriteLine();


            // Accessing the First member defined in the Enumeration
            Positions2 p2a = Positions2.Second;
            Console.WriteLine(p2a);          // Second
            Positions2 p2b = Positions2.Duo;
            Console.WriteLine(p2b);         // Second
            Positions2 p2c = Positions2.Two;
            Console.WriteLine(p2c);         // Second

            Console.WriteLine();

            // Working with sorted members in the enumeration having aliases.
            Positions3 p3a = Positions3.Second;
            Console.WriteLine(p3a);          // Due
            Positions3 p3b = Positions3.Duo;
            Console.WriteLine(p3b);         // Due
            Positions3 p3c = Positions3.Two;
            Console.WriteLine(p3c);         // Due
        }
    }
}
