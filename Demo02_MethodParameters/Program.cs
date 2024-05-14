using System.ComponentModel;

namespace Demo02_MethodParameters
{

    /// <summary>
    ///     The primary class containing the MAIN Method.
    /// </summary>
    internal class Program
    {

        /// <summary>
        ///     Main entry point to the application.
        /// </summary>
        /// <see cref="Program.PassByValueDemo(int)"/>
        static void Main()
        {
            // in-line comment
            /* 
             * block 
             * comment 
             */

            int a;
            string s;       // string variable

            a = 10;
            Console.WriteLine("-- Demo of PASS BY VALUE");
            Console.WriteLine($"Before: a = {a}");
            PassByValueDemo(a);
            Console.WriteLine($"After: a = {a}");
            Console.WriteLine();

            a = 10;
            Console.WriteLine("-- Demo of PASS BY REFERENCE");
            Console.WriteLine($"Before: a = {a}");
            PassByReferenceDemo(ref a);
            Console.WriteLine($"After: a = {a}");
            Console.WriteLine();

            a = 10;
            Console.WriteLine("-- Demo of PASS BY OUTPUT");
            Console.WriteLine($"Before: a = {a}");
            PassByOutDemo(out a);
            Console.WriteLine($"After: a = {a}");
            Console.WriteLine();
        }


        /// <summary>
        ///     Pass By Value Demo
        /// </summary>
        /// <param name="x">an integer parameter</param>
        /// <see cref="Console.WriteLine(string)" />
        static void PassByValueDemo(int x)
        {
            Console.WriteLine($"\t On Entry: x = {x}");
            x = 50;
            Console.WriteLine($"\t On Exit: x = {x}");
        }

        static void PassByReferenceDemo(ref int x)
        {
            Console.WriteLine($"\t On Entry: x = {x}");
            x = 50;
            Console.WriteLine($"\t On Exit: x = {x}");
        }

        // 1. Variable is not received in - WILL BE INITIALIZED TO NULL
        // 2. Variable needs to initialized by the functionality BEFORE EXITING THE FUNCTION
        static void PassByOutDemo(out int x)
        {
            // Console.WriteLine($"\t On Entry: x = {x}");
            // x++;
            // return;
            x = 50;
            Console.WriteLine($"\t On Exit: x = {x}");
        }
    }
}
