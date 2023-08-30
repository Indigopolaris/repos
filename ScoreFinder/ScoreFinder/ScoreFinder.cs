//William Slocum
//Mist 352
// Assignment 4 Part 1
// P.S. I do not follow sports very well so i used an online list of the 2012 top 15 NFL players passing scores and hard coded them into the app. 
using System;

public class ScoreFinder
{
    private int[] scores = new int[14]; // private array because the values are hardcoded on the test side of the app

    public ScoreFinder(int[] array) //constructor for the score array
    {
        scores = array;
    }

    public void ScoreFindPrompt() // a opening message method so the code looks more organized
    {
        Console.WriteLine("Please enter a passing score of the top 15 2012 athletes you wish to find."); 
        Console.WriteLine("--------------------------------------------------------------------------");

    }
    public void ScoreSearch(int[] array) //method that finds any matches to user input and prints the score,indecie, and a count of how many matches are found.
    {
        int userInput = int.Parse(Console.ReadLine());
        int count = 0; //counts the amount of matches found
        while(true) // makes sure the user inputs something so the following code can be ran
        {
            for (int i = 0; i < array.Length; i++) // for loop going from 0 to 14 to search for matches
            {
                if (scores[i] == userInput) 
                {
                    Console.WriteLine("score found:" +scores[i]); // messages to improve readability of the matches found.
                    Console.WriteLine("The indecie where the score was found is: " + i);
                    count++; 
                    Console.WriteLine($"there is {count} score match(es) found. ");
                    
                }
            }
            break;
        }
    }
}

