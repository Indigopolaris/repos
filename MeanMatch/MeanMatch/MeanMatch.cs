// William Slocum 
// Mist 352
// Assignment 4 part 1
using System;

public class MeanMatch
{

    public static void Main()
    {
        //establishing array and index var
        int i;
        int[] array = { 2, 4, 6, 6, 3 }; //used values from assignment
        int countofi = 0;

        int intplus;   //varible for the i+1 part of the equation

        int intminus;  // varible for the i-1 

        string indexwhat = "value of the indicies: "; // string var for display use later on

        string ivaluewhat = "values within indicies: ";

        for (i = 0; i < array.Length; i++) // putting together the equasion in the assignment doc via nested if else
        {
            
            if (i == 0)
            {
                intminus = 0; // if value is null it = 0
            }
            else
            { intminus = array[i - 1]; }
            if (i == array.Length - 1)
            {
                intplus = 0;
            }
            else
            {
                intplus = array[i + 1];
            }
            if(array[i] == (intminus + intplus)/2)
            {
                countofi++;
            }


            indexwhat += (" " + i); //string var with index value and then values inputted within indicies

            ivaluewhat +=(" " + array[i]);

        }


        Console.WriteLine(indexwhat);
        Console.WriteLine(ivaluewhat);
        Console.WriteLine("the number of values: " + countofi); //displays info on command screen   
    }
}
