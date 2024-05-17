using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo12_Interface.Demo03
{

    // DEMO: Interface Version
    // PURPOSE: Plug-In-Play code
    public class Driver
    {
        public void DriveAutomobile(IVehicle obj)
        {
            Console.Write("Driving by INTERFACE: ");
            obj.DriveVehicle();
        }
    }

    // PURPOSE: define standard behaviours that the type has to IMPLEMENT.
    // NOTE:
    //      Classes are INHERITED, Interfaces are IMPLEMENTED.
    //      All members are implicitly PUBLIC.
    //      All members of the interface need to be implemented.
    public interface IVehicle
    {
        void DriveVehicle();
        
        string RegistrationNumber { get; }
    }

    public class Car : IVehicle
    {
        public string RegistrationNumber { get; set; } = string.Empty;

        public void DriveVehicle()
        {
            Console.WriteLine("DriveCar() called");
        }
    }

    public class Scooter : IVehicle
    {
        public string RegistrationNumber { get; set; } = string.Empty;

        public void DriveVehicle()
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
