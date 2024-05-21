using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo21_Linq.Demo05
{
    internal class Demo
    {
        static internal void RunThis()
        {
            int[] arrInt = { 3, 20, 42, 11, 73, 5, 50, 86, 2, 1, 69, 34, 76, 92, 83 };

            Console.WriteLine("all the numbers");
            foreach(int i in arrInt)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // between 25 and 75 
            Console.WriteLine("all the numbers now filtered");
            foreach (int i in arrInt)
            {
                if (i >= 25 && i <= 75)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();


            // Infrastructural Code: What to do & how to do it
            Console.WriteLine("all the numbers now cloned, sorted, reversing and filtered");
            int[] arrClone = (int[])arrInt.Clone();
            System.Array.Sort(arrClone);          // in-place sorting (QuickSort algorithm)
            foreach (int i in arrClone.Reverse())
            {
                if (i >= 25 && i <= 75)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();

            // LINQ - Language INtegrated Query

            /****
             foreach (int i in arrInt)
             {
                 if (i >= 25 && i <= 75)
                 {
                     Console.Write($"{i} ");
                 }
             }
             *******/
            Console.WriteLine("Using LINQ");
            var query1 = from int i in arrInt
                        where i >= 25 && i <= 75
                        orderby i descending
                        select i;
            foreach (int i in query1)           // executes on enumeration
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();


            // FLUENT API EXAMPLE OF CODING
            Console.WriteLine("Using LAMBDA version");
            var query2 = arrInt.Where(i => i >= 25 && i <= 75)
                               .OrderByDescending(i => i)
                               .Select(i => i);
            foreach (int i in query2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine("Using Skip() and Take()");
            var query3 = query1.Skip(2).Take(3);
            foreach (int i in query3)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();


            Console.WriteLine("Demo of Projection");
            var query4 = from i in arrInt
                         where i >= 25 && i <= 75
                         select new
                         {
                             Number = i,
                             Description = $"Item with ID = {i}"
                         };
            foreach (var item in query4)
            {
                Console.WriteLine($"{item.Number} [ {item.Description} ] ");
            }
            Console.WriteLine();
        }
    }
}
