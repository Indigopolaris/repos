using System;

public class GradeBook
{
    //attributes
    private string courseName;

    private int[] grades;

    // constructor
    public GradeBook(string cname, int[] gradesArr)
    {
        courseName = cname;
        grades = gradesArr;
    }
    public void AssessGrades()
    {
        int countAs = 0, countBs = 0, countCs = 0, countDs = 0, countFs = 0;
        
        int total = 0;

        for(int i=0;i < grades.Length; i++)
        {
            switch(grades[i]/10)
            {
                case 10:
                case 9:
                    countAs++;
                    break;
                case 8:
                    countBs++;
                    break;
                case 7:
                    countCs++;
                    break;
                case 6:
                    countDs++;
                    break;
                default:
                    countFs++;
                    break;
            }

            total += grades[i];
        }

        double avg = (double)total / grades.Length;

        Console.WriteLine($"the avg of {grades.Length} grades is {avg:f}");

        foreach(int elem in grades) // you dont need to define indicies like in the above for statement^
        {
            total += elem;
        }

    }

}
