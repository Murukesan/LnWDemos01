namespace Demo15_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            string s = "hello world";
            object o;

            o = 10;                 // boxing
            i = (int)o;             // unboxing
            

            o = s;                  // boxing
            s = (string)o;          // unboxing

            i++;
            o = i;
            // o++;
            o = (int)o + 1;


            MyGenericType<int> objInt = new MyGenericType<int>();
            objInt.Value = 10;
            // objInt.Value = "abcd";
            objInt.DisplayMessage();


            MyGenericType<string> objString = new MyGenericType<string>();
            objString.Value = "Demo";
            objString.DisplayMessage();
        }
    }
}
