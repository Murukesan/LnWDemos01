namespace Demo20_ExceptionLibrary
{
    /// <summary>
    ///     Calculator Object
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        ///     Add two numbers
        /// </summary>
        /// <param name="a">First Number</param>
        /// <param name="b">Second Number</param>
        /// <returns>Sum of the two numbers</returns>
        public static int Add(int a, int b)
        {
            checked
            {
                return a + b;
            }
        }


        /// <summary>
        ///     Divide the first number with the second number
        /// </summary>
        /// <param name="a">First Number</param>
        /// <param name="b">Second Number</param>
        /// <returns>Divisor</returns>
        public static int Divide(int a, int b)
        {
            int result;
            
            if (b == 0)
            {
                throw new ArgumentException("SECOND ARGUMENT CANNOT BE ZERO");
            }

            try
            {
                checked
                {
                    result = a / b;
                }
            }
            catch (DivideByZeroException ex)
            {
                //Console.WriteLine("Something went wrong INSIDE Calculator.Divide(), and was caught.");
                //Console.WriteLine("TYPE: {0}", ex.GetType());
                //Console.WriteLine("MESSAGE: {0}", ex.Message);
                //Console.WriteLine("SOURCE: {0}", ex.Source);
                //Console.WriteLine("TARGETSITE: {0}", ex.TargetSite);
                // Console.WriteLine();

                result = -1;

                // throw new ArgumentException("SECOND ARGUMENT CANNOT BE ZERO", ex);
            }
            catch (ArithmeticException ex)
            {
                result = -1;
            }

            return result;
        }
    }
}
