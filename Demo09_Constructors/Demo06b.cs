using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09_Constructors
{
    class MyBaseClass4b
    {
        static MyBaseClass4b()
        {
            Console.WriteLine("STATIC Constructor of BASE CLASS called successfully");
        }

        public MyBaseClass4b()
        {
            Console.WriteLine("DEFAULT INSTANCE Constructor of BASE CLASS called successfully");
        }
    }

    class MyDerivedClass4b : MyBaseClass4b
    {
        static MyDerivedClass4b()
        {
            Console.WriteLine("STATIC Constructor of DERIVED CLASS called successfully");
        }

        public MyDerivedClass4b()
        {
            Console.WriteLine("DEFAULT INSTANCE Constructor of DERIVED CLASS called successfully}");
        }
    }
}
