namespace Demo03_ConvertingDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short a = 10;
            long b = a;             // implicit type conversion
            Console.WriteLine($"a = {a}, b = {b}");
   
            long m = 10;
            short n = (short)m;     // explicit type conversion
            Console.WriteLine($"m = {m}, n = {n}");

            long p = short.MaxValue + 1;
            short q = (short)p;
            Console.WriteLine($"p = {p}, q = {q}");

            // Enforce Arithmatic Overflow
            long p2 = short.MaxValue + 1;
            short q2, q3;
            checked
            {
                q2 = (short)p2;
                unchecked
                {
                    q3 = (short)p2;
                }
            }
            Console.WriteLine($"p2 = {p2}, q2 = {q2}, q3 = {q3}");


            string x1 = "1";
            string x2 = "  2  0 ";
            int y1 = int.Parse(x1);
            // int y2 = int.Parse(x2);              // will crash if invalid data
            int y4 = Convert.ToInt32(x2);           // will crash if invalid data

            // int y3;
            // if( int.TryParse(x2, out y3) )
            if( int.TryParse(x2, out int y3) )      // instantiate only when needed.
            {
                Console.WriteLine("-- was successfull!, y3 = {0}", y3);
            }
            else
            {
                Console.WriteLine("-- was NOT successfull!");
            }

            // Default value (0, false, null)
            int f = default;
            bool g = default;
            string? s = default;
            Console.WriteLine("f = {0}", f);
        }
    }
}
