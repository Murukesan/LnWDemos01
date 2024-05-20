namespace Demo14_Interface02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FirstDemo();
            // SecondDemo();
            // ThirdDemo();

            // Demo03.Demo.RunThis();
            Demo04.Demo.RunThis();
        }

        private static void ThirdDemo()
        {
            Demo02.Demo obj1 = new Demo02.Demo();
            obj1.DoSomething();         // implicit implementation of the method would be invoked.
            (obj1 as Demo02.IDemo).DoSomething();

            Console.WriteLine();

            Demo02.IDemo obj2 = new Demo02.Demo();
            obj2.DoSomething();                     // explicit implemntation of the method is invokable
            (obj2 as Demo02.Demo)?.DoSomething();    // object version
        }

        private static void SecondDemo()
        {
            // using the object.
            Demo14_Interface02.Demo01.Demo objDemo = new Demo01.Demo();
            objDemo.Name = "hello world";
            objDemo.DoSomething();

            // Implicitly creating the object as specified by the Interface
            // Demo14_Interface02.Dem01.IDemo objDemo2 = new Dem01.IDemo();        // Compiler Error
            Demo14_Interface02.Demo01.IDemo objDemo2 = new Demo01.Demo();
            // objDemo2.Name = "hello world";
            objDemo2.DoSomething();

            // objDemo2.Name = "hello world";
            Demo01.Demo? obj = objDemo2 as Demo01.Demo;
            if (obj != null)
            {
                obj.Name = "different world";
            }
            // (objDemo2 as Demo01.Demo)?.Name = "different world";
            // Console.WriteLine((objDemo2 as Demo01.Demo).Name);
        }

        private static void FirstDemo()
        {
            A objA = new A();
            objA.m();               // "one"
            B objB = new B();
            objB.m();               // "two"
            objB.n();
            A objA2 = new B();
            objA2.m();              // "two"
            // objA2.n();              // Compiler Error
        }
    }


    class A
    {
        virtual public void m() 
        {
            Console.WriteLine("one");
        }
    }

    class B : A
    {
        override public void m()
        {
            Console.WriteLine("two");
        }

        public void n() { }
    }
}
