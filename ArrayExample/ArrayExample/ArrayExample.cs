using System;

public class ArrayExample
{
    public static void Main()
    {
        int[] array1 = new int[10]; // size of array

        Console.WriteLine(array1[9]); // zero based counting!!!
        //put a value in to index 8
        array1[8] = 100;

        //bool[] myBoolArr = new bool[5];  //bool array
        //string[] myStringArr = new string[20]; //string array

        //using a for loop to print the values of the array
        for(int i=0; i<10; i++)  //the format is whatever starting pos, argument ((example: aslong as index is less than 10)), move to next indecie
        {
            if (i % 2 == 0)
                { array1[i] = 100; } //sets all indecies to 100

            Console.WriteLine(array1[i]);
        }

        for (int i = (array1.Length-1); i >= 0; i--)
        {
            Console.WriteLine($"the value at index {i} is {array1[i]}");
        }

        int[] array2 = { 11, 44, 66, 88, 100, 33, 55, 6, 3, 7, 99 };

        for (int i = 0; i < array2.Length; i++)
        {
            Console.WriteLine($"the value at index {i} is {array2[i]}");
        }

        string[] favColors = { "red", "orange", "blue", "yellow" };

        for (int i = 0; i < favColors.Length; i++)
        {
           Console.WriteLine("Enter one of your 4 fav colors");
           favColors[i] = Console.ReadLine();
        }
    }

}