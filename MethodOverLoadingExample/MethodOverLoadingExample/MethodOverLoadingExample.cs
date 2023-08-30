using System;

public class MethodOverloadingExample
{
    public static void main()
    {
        int x = 10;
        decimal y = 20;

        Change(x);
        Change(y);

        Console.WriteLine( )
    }
    public static void Change(int x)
    {
        x = x * 12;
    }
    public static void Change(decimal y)
    {
        y = y + 45;
    }
}