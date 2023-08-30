using System;

public class ArgumentPromotionExample
{
    public static void Main()
    {
        int y = 99;
        Modify(y);

        decimal someNum = 88.88m; //m is cast for decimal
    }
    public static void Modify(double x) //call works bc the int is promoted to a double "Argument promotion"
    {

    }
    public static void Modify()
    {

    }
}
