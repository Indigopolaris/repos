using System;

public class GradeBook
{
    //prop tab tab
    public int Credits { get; set; }

    public string Cname { get; set; }

    public GradeBook(int credits, string cname)
    {
        Credits = credits;
        Cname = cname;  
    }

    public void AssessGrades()
    {
        int total = 0;
        int numOfGrades = 0;
        int numOfA = 0;
        int numOfB = 0;
        int numOfC = 0;
        int numOfD = 0;
        int numOfF = 0;
        int grade;

        //ask for 1st value before loop starts
        Console.Write("enter a grade or ctrl+z to exit: ");
        string userinput = Console.ReadLine();

        string outputGrades = "";

        while(userinput != null)
        {
            grade = int.Parse(userinput);

            total += grade;

            numOfGrades++;

            switch(grade/10)// like nested
            {
                case 10:
                    
                case 9:
                    numOfA++;
                    break;
                case 8:
                    numOfB++;
                    break;
                case 7:
                    numOfC++;
                    break;
                case 6:
                    numOfD++;
                    break;
                default:
                    numOfF++;
                    break;

                
            }

            outputGrades = outputGrades + $"Grade {numOfGrades} is {grade}\n";

            //if (grade >= 90)
            //    numOfA++;
            //else if (grade >= 80)
            //    numOfB++;
            //else if (grade >= 70)
            //    numOfC++;
            //else if (grade >= 60)
            //    numOfD++;
            //else 
            //    numOfF++;
            //ask for next input

            Console.Write("enter next grade or ctrl + z to exit: ");

            userinput = Console.ReadLine();
        }

        double avg = (double)total / numOfGrades;

        Console.WriteLine($"the avg of the {numOfGrades} grades is {avg:f}");

        Console.WriteLine($"number of A's: {numOfA}\nnumber of B's: {numOfB}\nnumber of C's: {numOfC}\nnumber of D's: {numOfD}\nnumber of F's: {numOfF}\n");

        Console.WriteLine(outputGrades);
     }

}