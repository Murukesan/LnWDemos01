namespace Demo01_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("Enter name: ");
            string? name = Console.ReadLine();      // null-safe

            Console.Write("Enter age: ");
            string? ageInput = Console.ReadLine();

            int age;

            if(ageInput == null)
            {
                age = int.Parse("0");
            }
            else
            {
                age = int.Parse(ageInput);
            }
            age = (ageInput == null) ? int.Parse("0") : int.Parse(ageInput);
            age = int.Parse(Console.ReadLine() ?? "0"); // null-check operator


            Console.WriteLine("Hi " + name + ". You are " + age.ToString() + " years old");
            
            // positional parameters version
            Console.WriteLine("Hi {0}, you are {1} years old", name, age);

            string output = string.Format("Hi {0}, you are {1} years old", name, age);
            Console.WriteLine(output);

            // string interpolated version
            Console.WriteLine($"Hi {name}, you are {age} years old.");
        }
    }
}
