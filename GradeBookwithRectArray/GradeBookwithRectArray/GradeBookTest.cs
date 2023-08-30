using System;

public class GradeBookTest
{

    public static void Main()
    {
        string cn = "Mist 352";

        //int[,] grades = new int[5, 4]; array creation exp

        //array initializer list
        int[,] grades = { { 11, 22, 33, 44
            },
                          { 44, 55, 66, 77
            },
                          { 55, 88, 99, 100
            },
                          { 100, 55, 33, 44
            }
        };
        GradeBook mygb = new GradeBook(cn, grades);
        mygb.AssessGrades();
    }
}