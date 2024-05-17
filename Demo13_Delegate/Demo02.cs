using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo13_Delegate.Demo02
{
    public delegate int ComputeHandler(int x, int y);

    sealed public class Calculator
    {
        public int Compute(int x, int y, ComputeHandler objD)
        {
            int result;

            Console.WriteLine("--- Encapsulation steps:");
            Console.WriteLine("1. Authentication");
            Console.WriteLine("2. Authorization");
            Console.WriteLine("3. Validation");
            Console.WriteLine("4. Activity / Process");
            result = objD(x, y);
            Console.WriteLine("5. Audit Logging");

            return result;
        }

        public int Add(int x, int y)
        {
            int result;

            Console.WriteLine("--- Encapsulation steps:");
            Console.WriteLine("1. Authentication");
            Console.WriteLine("2. Authorization");
            Console.WriteLine("3. Validation");
            Console.WriteLine("4. Activity / Process");
            result = x + y;
            Console.WriteLine("5. Audit Logging");

            return result;
        }
    }

    public class Demo
    {
        public void RunThis()
        {
            Calculator objCalculator = new Calculator();

            int result;
            
            result = objCalculator.Add(10, 20);
            Console.WriteLine("Add result: {0}",  result);

            Console.WriteLine();

            result = Demo.Subtract(200, 10);
            Console.WriteLine("Subtract result: {0}", result);

            Console.WriteLine();

            result = objCalculator.Compute(500, 20, Demo.Subtract);
            Console.WriteLine("Subtract result: {0} using Delegate", result);
        }

        private static int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}
