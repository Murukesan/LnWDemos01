using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo21_Linq
{
    internal class Demo02
    {
        internal static void RunThis()
        {
            int i = 5;
            Console.WriteLine(i);

            Calculator objCalc = new Calculator();
            objCalc.Add(10, 20);

            // call directly - just like an ordinary call
            MyExtensions.Subtract(objCalc, 5, 20);

            // call using the extension method
            objCalc.Subtract(5, 300);
        }
    }


    sealed class Calculator
    {
        internal int Add(int a, int b)
        {
            return a + b;
        }

        internal int Subtract(int a, int b)
        {
            Console.WriteLine("--- explicit implementation in the class was called!");
            return b - a;
        }
    }

    static class MyExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objCalc">the extension object instance to which the method would be attached</param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static public int Subtract(this Calculator objCalc, int a, int b)
        {
            Console.WriteLine("--- extention method was called!");
            return a - b;
        }
    }
}
