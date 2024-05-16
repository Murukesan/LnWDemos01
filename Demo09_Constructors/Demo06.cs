using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09_Constructors
{
    class MyBaseClass4
    {
        static MyBaseClass4()
        {
            Console.WriteLine("STATIC Constructor of BASE CLASS called successfully");
        }

        public MyBaseClass4()
        {
            Console.WriteLine("DEFAULT INSTANCE Constructor of BASE CLASS called successfully");
        }
    }

    class MyDerivedClass4 : MyBaseClass4
    {
        static MyDerivedClass4()
        {
            Console.WriteLine("STATIC Constructor of DERIVED CLASS called successfully");
        }

        public MyDerivedClass4()
        {
            Console.WriteLine("DEFAULT INSTANCE Constructor of DERIVED CLASS called successfully}");
        }
    }
}
