using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_BoxingUnboxing
{
    public class Driver
    {
        public void DriveVehicle(object obj)
        {
            // Throws error if object is not a Car type
            // Car car = (Car)obj;                 // unboxing (EXPLICIT) 

            if (obj.GetType() == typeof(Car))
            {
                Car car = (Car)obj;                 // unboxing (EXPLICIT) 
                car.Drive();
            }
            else if (obj is Scooter)        // IS operator (type-checker operator)
            {
                // AS Operator is the SAFE TYPE CAST Operator
                // AS Operator returns NULL if it is not able to typecast successfully!
                // AS Operator works ONLY WITH reference types.
                Scooter? scooter = obj as Scooter;  // unboxing (EXPLICIT) with AS Operator

                //if(scooter is not null)
                //{
                //    scooter.Drive();
                //}

                scooter?.Drive();       // NULL-SAFE operator (?.)
            }
        }

        public void DriveCar(Car obj)
        {
            obj.Drive();
        }

        public void DriveScooter(Scooter obj)
        {
            obj.Drive();
        }
    }

    public class Car
    {
        public void Drive()
        {
            Console.WriteLine("Car is being driven");
        }
    }

    public class Scooter
    {
        public void Drive()
        {
            Console.WriteLine("Scooter is being driven");
        }
    }
}
