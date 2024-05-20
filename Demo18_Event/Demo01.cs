using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo18_Event.Demo01
{
    internal class Process
    {
        public void DoSomething()
        {
            Console.WriteLine("--- step 1 executed");

            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("--- step 2 executed");

            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("--- step 3 executed");

            DoStep4();

            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("--- step 5 executed");
        }

        private void DoStep4()
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("--- step 4 executed");
            throw new Exception("SOMETHING WENT WRONG IN STEP 4");
        }
    }
}
