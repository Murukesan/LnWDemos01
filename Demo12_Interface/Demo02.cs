using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12_Interface.Demo02
{

    // DEMO: Boxing/Unboxing Version 
    // Due to the needs of being able to call explicitly defined member

    public class Driver
    {
        public void DriveAutomobile(object obj)     // objDriver.DriveAutomobile(objCar) <- boxing
        {
            Console.Write("Driving by BOXING / UNBOXING: ");
            if (obj.GetType() == typeof(Car) )
            {
                Car objCar = (Car)obj;              // unboxing
                objCar.DriveCar();
            }
            else if (obj is Scooter)                // (obj.GetType() == typeof(Scooter))
            {
                Scooter? objScooter = obj as Scooter;    // (Scooter)obj;
                //if(objScooter != null)
                //{
                //    objScooter.DriveScooter();
                //}
                objScooter?.DriveScooter();         // NULL-SAFE OPERATOR

                // -- instead of lines 23..28
                // (obj as Scooter)?.DriveScooter();
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
