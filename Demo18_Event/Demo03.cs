using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo18_Event.Demo03
{

    delegate void ProcessCrashHandler(string message);


    // Demo using Delegate implementing DEPENDENCY INJECTION PATTERN
    internal class Process
    {
        private readonly ProcessCrashHandler? _callbackHandler;

        public Process(ProcessCrashHandler handler)
        {
            _callbackHandler = handler;
        }

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
            if(_callbackHandler != null)     // check if the callback delegate is "subscribed" to
            {
                _callbackHandler("SOMETHING WENT WRONG IN STEP 4");
            }
        }
    }
}
