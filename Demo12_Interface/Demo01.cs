using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12_Interface
{
    namespace Demo01
    {
        // DEMO: Overloaded Version 
        // Due to the needs of being able to call explicitly defined member

        public class Driver
        {
            public void DriveAutomobile(Car obj)
            {
                Console.Write("Driving by OVERLOAD: ");
                obj.DriveCar();
            }

            public void DriveAutomobile(Scooter obj)
            {
                Console.Write("Driving by OVERLOAD: ");
                obj.DriveScooter();
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
            public static void RunThis()
            {
                // CLIENT CODE

                Driver objDriver = new Driver();
                Car objCar = new Car();
                Scooter objScooter = new Scooter();

                objDriver.DriveAutomobile(objCar);
                objDriver.DriveAutomobile(objScooter);
            }
        }
    }
}
