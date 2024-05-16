using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09_Constructors
{
    class MyBaseClass
    {
        public MyBaseClass()
        {
            Console.WriteLine("Constructor of BASE CLASS called successfully");
        }
    }

    class MyDerivedClass : MyBaseClass 
    {
        public MyDerivedClass()
        {
            Console.WriteLine("Constructor of DERIVED CLASS called successfully");
        }
    }
}
