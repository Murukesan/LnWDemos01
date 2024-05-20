using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo14_Interface02.Demo01
{
    public interface IDemo
    {
        string Name { get; }

        void DoSomething();
    }

    /// <summary>
    ///     IMPLICIT IMPLEMENTATION of the Interface
    /// </summary>
    public class Demo : IDemo
    {
        public string Name { get; set; }

        public void DoSomething() 
        {
            Console.WriteLine("DoSomething called!");
        }
    }
}
