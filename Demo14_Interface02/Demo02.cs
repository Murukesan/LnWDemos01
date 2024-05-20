using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo14_Interface02.Demo02
{
    public interface IDemo
    {
        void DoSomething();
    }

    public class Demo : IDemo
    {
        /******************
        // IMPLICIT Implementation of the Interface Signature
        public void DoSomething() 
        {
            Console.WriteLine("Demo.DoSomething() called");
        }
        *****/

        // EXPLICIT Implementation of the Interface Signature
        void IDemo.DoSomething()
        {
            Console.WriteLine("Demo.DoSomething() called - EXPLICIT IMPLEMENTATION VERSION");
        }

        public void DoSomething()
        {
            Console.WriteLine("Demo.DoSomething() called - OBJECT TYPE VERSION");
        }

        //virtual public void m() { }
        //override public void m() { }
    }
}
