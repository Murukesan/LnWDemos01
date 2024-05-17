using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo13_Delegate.Demo01
{

    // DEMO: Delegate
    // PURPOSE: To define the Method Signature of the method that needs to be called (i.e. INVOKED)
    public delegate void DriveHandler();

    public class Driver
    {
        public void DriveAutomobile(DriveHandler objDelegate)
        {
            Console.Write("Driving by DELEGATE: ");

            // MUST Check if the Delegate is SUBSCRIBED (i.e., points to a method to invoke)
            if (objDelegate != null)
            {
                objDelegate();          // invoking the method pointed to by the delegate variable
            }
        }
    }

    public class Car
    {
        public void DriveCar()
        {
            Console.WriteLine("DriveCar() called");
        }
    }

    public class Scooter
    {
        public void DriveScooter()
        {
            Console.WriteLine("DriveScooter() called");
        }
    }

    public class Demo
    {
        public void DoSomething()
        {
            Console.WriteLine("something is being done here!");
        }

        private static void DoSomethingElse()
        {
            Console.WriteLine("something else called!");
        }

        public static void RunThis()
        {
            // CLIENT CODE

            Driver objDriver = new Driver();
            Car objCar = new Car();
            Scooter objScooter = new Scooter();

            //objDriver.DriveAutomobile( objCar.DriveCar() );         // nested call version

            objDriver.DriveAutomobile(objCar.DriveCar);             // pass pointer of the method to invoke
            objDriver.DriveAutomobile(objScooter.DriveScooter);

            Console.WriteLine();

            // -- Delegate object initialized IMPLICITLY
            // objDriver.DriveAutomobile(objCar.DriveCar);
            // 
            // -- Delegate object initialized EXPLICITLY
            DriveHandler objD = new DriveHandler(objCar.DriveCar);
            objDriver.DriveAutomobile(objD);

            Console.WriteLine();

            Demo objDemo = new Demo();
            objDriver.DriveAutomobile(objDemo.DoSomething);         // calling an instance member
            objDriver.DriveAutomobile(Demo.DoSomethingElse);        // type member

            DriveHandler objD2 = null;
            objDriver.DriveAutomobile(objD2);
        }
    }
}
