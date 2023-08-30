using System;

public class ScoreFinderTest
{
    public static void Main() 
    {
        int[] scorearray = {104,96,96,95,95,94,94,93,92,92,91,90,87,87,86}; //score array to hold hard coded score values, top 15 2012 athletes.

        ScoreFinder scoretest = new ScoreFinder(scorearray); //scorefinder obj initialization
        
        
        scoretest.ScoreFindPrompt();  //call method to display user instructions
        scoretest.ScoreSearch(scorearray); // calls the search method

    }
}
