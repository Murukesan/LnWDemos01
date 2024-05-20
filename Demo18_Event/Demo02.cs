using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo18_Event.Demo02
{

    delegate void ProcessCrashHandler(string message);


    // Demo of DELEGATE
    internal class Process
    {
        public void DoSomething(ProcessCrashHandler objCallback)
        {
            Console.WriteLine("--- step 1 executed");

            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("--- step 2 executed");

            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("--- step 3 executed");

            DoStep4(objCallback);

            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("--- step 5 executed");
        }

        private void DoStep4(ProcessCrashHandler objCallback)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("--- step 4 executed");
            if(objCallback != null)     // check if the callback delegate is "subscribed" to
            {
                objCallback("SOMETHING WENT WRONG IN STEP 4");
            }
        }
    }
}
