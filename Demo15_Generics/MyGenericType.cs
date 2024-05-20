using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo15_Generics
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class MyGenericType<T>
    {
        public T Value { get; set; }

        public void DisplayMessage()
        {
            Console.WriteLine("hello world from Generic Type object with the value: {0}", this.Value);
        }
    }
}
