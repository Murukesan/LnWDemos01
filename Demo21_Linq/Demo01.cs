using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo21_Linq
{
    internal class Demo01
    {

        public static void RunThis()
        {
            int i = 10;
            string s = "Hello world";

            // Type inference (TYPE SAFE)
            // NEEDS INITIALIZATION coz. it has to infer the datatype on assignment
            var o1 = 1;
            var o2 = "hello world";
            o1++;

            // Needs explicit unboxing before consuming
            object p1 = 1;                      // boxing
            object p2 = "hello world";          // boxing
            // p1++;
            p1 = (int)p1 + 1;
        }
    }
}
