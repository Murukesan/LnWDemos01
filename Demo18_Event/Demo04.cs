using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo18_Event.Demo04
{

    delegate void ProcessCrashHandler(string message);


    // Demo using EVENT
    internal class Process
    {
        public event ProcessCrashHandler? OnProcessFailure;

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
            if(OnProcessFailure != null)     // check if the event is "subscribed" to
            {
                // raise the event
                OnProcessFailure("SOMETHING WENT WRONG IN STEP 04 and event was raised!");
            }
            Console.WriteLine("exiting the functionality");
        }
    }
}
