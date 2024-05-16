namespace Demo09_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo01();

            //Demo02();

            //Demo03();

            // Demo04();

            // Demo05();

            // Demo05b();

            // Demo06();

            Demo07a();
            Console.WriteLine("------");
            Demo07b();
        }

        static void Demo01()
        {
            Demo01 obj = new Demo01();
        }

        static void Demo02()
        {
            Demo02 obj;         // Declaration

            obj = new Demo02(); // Instantiation
        }

        static void Demo03()
        {
            Demo03 obj1, obj2, obj3;         // Declaration

            obj1 = new Demo03();             // Instantiation using Default Constructor
            obj2 = new Demo03(10);
            obj3 = new Demo03(10, "First Employee");
        }

        static void Demo04()
        {
            // MyBaseClass objBase = new MyBaseClass();

            MyDerivedClass objDerived = new MyDerivedClass();
        }

        static void Demo05()
        {
            // MyBaseClass2 objBase = new MyBaseClass2(10);

            // MyDerivedClass2 objDerived1 = new MyDerivedClass2();

            MyDerivedClass2 objDerived2 = new MyDerivedClass2(10);
        }

        static void Demo05b()
        {
            MyDerivedClass3 objDerived1 = new MyDerivedClass3();
            Console.WriteLine();

            MyDerivedClass3 objDerived2 = new MyDerivedClass3(10);
            Console.WriteLine();

            MyDerivedClass3b objDerived3 = new MyDerivedClass3b();
        }

        static void Demo06()
        {
            Employee emp1, emp2, emp3;

            // OBJECT INITIALIZATION
            // Calling the Default Constructor AND THEN initiazing the Properties.
            // emp1 = new Employee() { Id = 1, Name = "First Employee" };
            
            emp1 = new Employee(1, "First Employee");
            emp1.CompanyName = "Microsoft";

            emp2 = new Employee(2, "Second Employee");
            emp2.CompanyName = "Microsoft";
            emp3 = new Employee(3, "Third Employee");
            emp3.CompanyName = "Microsoft";

            // emp1.Location = "Bangalore";
            Employee.Location = "Bangalore";
        }

        static void Demo07a()
        {
            // MyBaseClass4 objBase = new MyBaseClass4();

            MyDerivedClass4 obj1 = new MyDerivedClass4();
        }

        static void Demo07b()
        {
            // Inheritance is TOP-DOWN, 
            // Execution is BOTTOM-UP

            // MyDerivedClass4 objDerived = new MyBaseClass4();  // compiler error

            // Inheritance is TOP-DOWN
            // Create an object of the parent with behaviours of the child
            MyBaseClass4b objBase = new MyDerivedClass4b();
        }
    }
}
