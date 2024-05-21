using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo21_Linq.Demo03
{
    // Anonymous Methods
    internal class Demo
    {
        internal static void RunThis()
        {
            int x = 5, y = 20, z;

            Calculator objCal = new Calculator();

            z = objCal.Compute(Demo.Add, x, y);                     // delegate object instantiated implicitly
            Console.WriteLine($"{x} + {y} = {z}");
            Console.WriteLine();


            // explanation of LINE #18 => LINE 24 & 25
            ComputeHandler objD1 = new ComputeHandler(Demo.Add);     // delegate object instantiated explicitly
            z = objCal.Compute(objD1, x, y);
            Console.WriteLine($"{x} + {y} = {z}");
            Console.WriteLine();

            // Anonymous Method - LINE #24 is replaced using ANONYMOUS METHOD
            ComputeHandler objD2 
                = delegate (int m, int n)
                {
                    Console.WriteLine("-- Anonymous method was called.");
                    return n - m;
                };
            z = objCal.Compute(objD2, x, y);
            Console.WriteLine($"{y} - {x} = {z}");
            Console.WriteLine();


            // Anonymous Method Simplified Version ( Arrow Function available due to "goes to" operator )
            ComputeHandler objD3
                = (int m, int n) 
                  =>                        // GOES TO Operator
                    {
                        Console.WriteLine("-- Anonymous method was called.");
                        return n - m;
                    };
            z = objCal.Compute(objD3, x, y);
            Console.WriteLine($"{y} - {x} = {z}");
            Console.WriteLine();


            // Further Simplified Version Anonymous Method
            var somevariable = 1000;            // hook to the shared member
            ComputeHandler objD4
                = (m, n) =>
                {
                    Console.WriteLine("-- Anonymous method was called.");
                    return n - m + somevariable;
                };
            z = objCal.Compute(objD4, x, y);
            Console.WriteLine($"{y} - {x} = {z}");
            Console.WriteLine();

            // LAMBDA EXPRESSION VERSION of Anonymous Method
            //ComputeHandler objD5
            //    = (m, n) =>
            //    {
            //        return n - m + somevariable;
            //    };
            ComputeHandler objD5
                = (m, n) => n - m + somevariable;
        }

        private static int Add(int m, int n)
        {
            Console.WriteLine("-- Demo.Add() was called.");
            return m + n;
        }
    }

    // definition of the method to be invoked.
    delegate int ComputeHandler(int a, int b);

    internal class Calculator
    {
        internal int Compute(ComputeHandler? objD, int a, int b)
        {
            int result = -1;

            // Encapsulated: 1. 2. 3. 4. 5.

            if (objD != null)
            {
                Console.WriteLine("method invoked using the delegate from the Compute Method");
                result = objD(a, b);
            }

            return result;
        }
    }

}
