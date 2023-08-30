using System;

public class GradeBook
{

    //attributes 
    private string coursename;
    private int[,] gradeArr;

    //constructor
    public GradeBook(string cn, int[,] grades)
    {
        coursename = cn;
        gradeArr = grades;
    }
    public void AssessGrades()
    {
        int total = 0;

       for(int r = 0; r < gradeArr.GetLength(0); r++)
        {
            for(int c = 0; c < gradeArr.GetLength(1); c++)
            {
               Console.WriteLine($"Row {r}, col {c} : {gradeArr[r,c]}" );



            }
            //calc avg of current row (student)
            Console.WriteLine($"the avg of the student at the index {r} " + CalcStudentAvg(r));

        }

        // assess the grades to find out how many grades fall in each range
        int[] gradeCounters = new int[11]; //0 to 100 by tens, so 11 groups

        for(int r = 0; r < gradeArr.GetLength(0); r++)
        {
            for(int c=0; c < gradeArr.GetLength(1);c++)
            {
                //if(gradeArr[r,c] >= 90 && gradeArr[r,c] <= 99)
                //{
                //    gradeCounters[9]++;
                //}
                //else if (gradeArr[r,c] >= 80 && gradeArr[r,c] <= 89)
                //{
                //    gradeCounters[8]++;
                //}
                //else if (gradeArr[r, c] >= 70 && gradeArr[r, c] <= 79)
                //{
                //    gradeCounters[7]++;
                //}

                gradeCounters[gradeArr[r,c]/10]++;
            }

            
        }

        Console.WriteLine();
        for (int i = 0; i < gradeCounters.Length; i++)
        {
            Console.WriteLine($"{i}0s - {gradeCounters[i]}");

        }

    }

    public decimal CalcStudentAvg(int row)
    {
        int studentTotal = 0;
        for(int col =0; col < gradeArr.GetLength(1); col++)
        {
            studentTotal += gradeArr[row, col];// iterate through current row and add all grades for current student
           
        }
        decimal avg = studentTotal / gradeArr.GetLength(1);
        return avg;
    }
}
