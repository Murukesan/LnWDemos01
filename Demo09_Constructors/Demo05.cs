using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09_Constructors
{
    class MyBaseClass2
    {
        public MyBaseClass2()
        {
            Console.WriteLine("Default Constructor of BASE CLASS called successfully");
        }

        public MyBaseClass2(int id)
        {
            Console.WriteLine("Parameterized Constructor of BASE CLASS called successfully with {0}", id);
        }
    }

    class MyDerivedClass2 : MyBaseClass2 
    {
        public MyDerivedClass2()
        {
            Console.WriteLine("Default Constructor of DERIVED CLASS called successfully");
        }

        public MyDerivedClass2(int id)
        {
            Console.WriteLine("Parameterized Constructor of DERIVED CLASS called successfully with {0}", id);
        }
    }
}
