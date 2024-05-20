
IEnumerator m()                 // GetEnumerator()
{
    for(int i = 0; i < 3; i++)
    {
        yield return i;
    }
}
=> readonly forwardonly array [ 0, 1, 2 ] with .MoveNext(), .Reset() .Current

Main()
{
    Console.WriteLine( "1: {0}", m() );   // 1:  0  ( .Reset() + .MoveNext() + if true .Current )
    Console.WriteLine( "2: {0}", m() );   // 2:  1  ( .MoveNext() => TRUE .Current )
    Console.WriteLine( "3: {0}", m() );   // 3:  2  ( .MoveNext() => TRUE .Current )
    Console.WriteLine( "4: {0}", m() );   // 4:  0  ( .MoveNext() => FALSE, .Reset(), MoveNext() => True, .Current)
}