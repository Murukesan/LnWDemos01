namespace Demo06_BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demo01();

            Demo02();
        }

        static void Demo01()
        {
            int i = 10;
            object o = i;          // Boxing - IMPLICIT CONVERSION
            Console.WriteLine("i = {0}, i.GetType() = {1}", i, i.GetType());
            Console.WriteLine("o = {0}, o.GetType() = {1}", o, o.GetType());

            int j = (int)o;        // Unboxing - EXPLICIT CONVERSION

            i++;
            // o++;
            o = (int)o + 1;

            // AS operator does not work with ValueTypes
            // int x = o as int;
            int x = (int)o;
        }

        static void Demo02()
        {
            Driver objDriver = new Driver();
            Car objCar = new Car();
            Scooter objScooter = new Scooter();

            Console.WriteLine("-- Explicit Method invocation demo");
            objDriver.DriveCar(objCar);
            objDriver.DriveScooter(objScooter);

            Console.WriteLine("-- Boxing and Unboxing demo");
            objDriver.DriveVehicle(objCar);     // boxing IMPLICITLY
            object objS = objScooter;           // boxing explicitly by assigning to variable.
            objDriver.DriveVehicle(objS);
        }

    }
}
