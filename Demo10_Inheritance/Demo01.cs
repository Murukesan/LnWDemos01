using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10_Inheritance
{
    class MyBase
    {

        virtual public int Id { get; set; }

        public int Add(int a, int b)
        {
            Console.WriteLine("called: MyBase.Add(int, int)");
            return a + b;
        }

        // Overload of: int Add(int, int)
        public int Add(int x, int y, int z)
        {
            Console.WriteLine("called: MyBase.Add(int, int, int)");
            return x + y + z;
        }


        // "virtual" ALLOWS OVERRIDE
        virtual public void ShowInfo()
        {
            Console.WriteLine("MyBase.ShowInfo() called");
        }

        virtual public int Add()
        {
            Console.WriteLine("called: MyBase.Add()");
            return 0;
        }
    }

    class MyDerived : MyBase
    {
        override public int Id { get; set; }


        // Overload of: int Add(int, int)
        // Overload of: int Add(int, int, int)
        public int Add(int x, int y, int z, int a)
        {
            Console.WriteLine("called: MyDervied.Add(int, int, int, int)");
            return x + y + z + a;
        }

        // "override" redefines the signature coming from the parent
        public override void ShowInfo()
        {
            Console.WriteLine("MyDerived.ShowInfo() called");
        }

        override public int Add()
        {
            Console.WriteLine("called: MyDerived.Add()");
            return 10;
        }
    }
}
