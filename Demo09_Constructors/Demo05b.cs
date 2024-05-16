using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09_Constructors
{
    class MyBaseClass3
    {
        //public MyBaseClass3()
        //{
        //    Console.WriteLine("Default Constructor of BASE CLASS called successfully");
        //}

        public MyBaseClass3(int id)
        {
            Console.WriteLine("Parameterized Constructor of BASE CLASS called successfully with {0}", id);
        }
    }

    class MyDerivedClass3 : MyBaseClass3
    {
        // Initializer
        public MyDerivedClass3() : base(0)
        {
            Console.WriteLine("Default Constructor of DERIVED CLASS called successfully");
        }

        public MyDerivedClass3(int id) : base(id)
        {
            Console.WriteLine("Parameterized Constructor of DERIVED CLASS called successfully with {0}", id);
        }
    }

    class MyDerivedClass3b : MyBaseClass3
    {
        // Initializer
        public MyDerivedClass3b() : this(0)
        {
            Console.WriteLine("Default Constructor of DERIVED CLASS called successfully");
        }

        public MyDerivedClass3b(int id) : base(id)
        {
            Console.WriteLine("Parameterized Constructor of DERIVED CLASS called successfully with {0}", id);
        }
    }
}

