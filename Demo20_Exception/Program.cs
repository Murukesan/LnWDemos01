using Demo20_ExceptionLibrary;

namespace Demo20_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculator calcultor = new Calculator();
            int x = 10, y = 5, result;

            result = Calculator.Add(x, y);
            Console.WriteLine($"Add result: {result} [ {x} + {y} ]");

            result = Calculator.Divide(x, y);
            Console.WriteLine($"Divide result: {result} [ {x} / {y} ]");

            Console.WriteLine();

            try
            {
                y = 0;
                result = Calculator.Divide(x, y);
                Console.WriteLine($"Divide result: {result} [ {x} / {y} ]");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong and was caught in Main()");
                Console.WriteLine("TYPE: {0}", ex.GetType());
                Console.WriteLine("MESSAGE: {0}", ex.Message);
                Console.WriteLine("SOURCE: {0}", ex.Source);
                Console.WriteLine("TARGETSITE: {0}", ex.TargetSite);

                Exception? inner = ex?.InnerException;
                while(inner != null)
                {
                    Console.WriteLine("\t TYPE: {0}", inner.GetType());
                    Console.WriteLine("\t MESSAGE: {0}", inner.Message);
                    Console.WriteLine("\t SOURCE: {0}", inner.Source);
                    Console.WriteLine("\t TARGETSITE: {0}", inner.TargetSite);
                    inner = inner.InnerException;
                }
                Console.WriteLine();
            }
            finally
            {
                Console.WriteLine("----- Thank you for using the ADD tool");
                Console.WriteLine();
            }


            try
            {
                y = 1;
                x = int.MaxValue;
                result = Calculator.Add(x, y);
                Console.WriteLine($"Add result: {result} [ {x} + {y} ]");
            }
            //catch (ArithmeticException)
            //{
            //    Console.WriteLine("Failed: [ {x} + {y} ]");
            //}
            finally
            {
                Console.WriteLine("----- Thank you for using the DIVIDE tool");
                Console.WriteLine();
            }

            Console.WriteLine("========= EXITING MAIN");
        }
    }
}
