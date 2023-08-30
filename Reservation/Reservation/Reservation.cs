//William Slocum 
//Mist 352
// Assignment 4 part 2


using System;

    public class SeatReservation
    {
        char[,] reservation = new char[10, 2]; // multideminsional array 10 by 2

        public SeatReservation(char[,] array)   // constructor for the seat array
        {
            reservation = array;
        }

        public void seatUserPrompt() // message to instruct user 
        {
            Console.WriteLine("Please type 1 if the passenger has first class seating: ");
            Console.WriteLine("Please type 2 if the passneger has economy seating: ");
            Console.WriteLine("Please type 3 if you wish to see the current seating status: ");
            Console.WriteLine("Please type 9 if you want to quit");
            Console.WriteLine("Please enter 1 for first class, 2 for economy, 3 to display availibility, or 9 to exit.");
            Console.WriteLine("================================================================");
         }
    public void SeatUserDisplay(char[,] array)
        {
            Console.WriteLine("Seat Avalibility status:");
         for (int i = 0; i < 10; i++)
          { Console.WriteLine(array[i, 0] + "\t" + array[i, 1]); } //print all seat status for both columns

            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("Please enter 1 for first class, 2 for economy, 3 to display availibility, or 9 to exit.");

        }

        //used to check seat availibility
        public static bool seatACheck(char[,] array, char seatType)
        {
            //checks if first class has availability
            bool available = false;
            if (seatType == 'F')
            {
                for(int i = 4; i >= 0; i--)  //start from indecie 4 (5th row) going upwards to 0 (1st row)
                {
                    if (array[i,0] == 'A' || array[i ,1] == 'A') //checks both columns for availability
                    {
                        available = true;
                        break;
                    }
                }
            }
            //else checks if econ is available
            else
            {
                for (int i = 9; i >= 5; i--)  // goes from indecie 9 (10th row) to 5 (6th row)
                {
                    if(array[i,0] == 'A' || array[i, 1] == 'A')
                    {
                        available = true;
                    }
                }
            }
            return available;
        }

        //used to reserve first class seats
        public void firstClass(char[,] arr)
        {


            //fills first class from row 4 to row 0
            if (seatACheck(arr, 'F'))
            {
                for (int i = 4; i >= 0; i--)
                {
                    if (arr[i, 0] == 'A')
                    {
                        arr[i, 0] = 'X'; //if available fill with x for taken in the first column
                        break;
                    }
                    else if (arr[i, 1] == 'A')
                    {
                        arr[i, 1] = 'X'; //fill second column with x 
                        break;
                    }
                }
                Console.WriteLine("You ticket has been reserved, enjoy your flight.");
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.WriteLine("Please enter 1 for first class, 2 for economy, 3 to display availibility, or 9 to exit.");
            }

            else
            {
                //if first class is not available offers economy seating
                if (seatACheck(arr, 'E') == false)
                {
                    Console.WriteLine("Sorry, no tickets are available, next flight leaves in 3 hours");
                }
                else
                {
                    string bookEcon = "A";
                    Console.Write("No tickets are available in First class do you want to book Economy class ticket?(Y/N): ");
                    bookEcon = Console.ReadLine();

                    if (bookEcon.ToUpper() == "Y") //ToUpper() is used to insure capital letters are used, to prevent error.
                    {
                        economyClass(arr);
                    }
                    else
                    {
                        Console.WriteLine("Next flight leaves in 3 hours.");
                        Console.WriteLine("---------------------------------------------------------------------------------------");
                        Console.WriteLine("Please enter 1 for first class, 2 for economy, 3 to display availibility, or 9 to exit.");
                    }
                }
            }
        }


        //used to book economy seating (rows 5-9)

        public void economyClass(char[,] arr)
        {
            //starts at row 9 and moves upward to row 5

            if (seatACheck(arr, 'E'))
            {
                for (int i = 9; i >= 5; i--)
                {
                    if (arr[i, 0] == 'A')
                    {
                        arr[i, 0] = 'X';
                        break;
                    }
                    else if (arr[i, 1] == 'A')
                    {
                        arr[i, 1] = 'X';
                        break;
                    }
                }
                Console.WriteLine("You seat has been reserved, enjoy your flight.");
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.WriteLine("Please enter 1 for first class, 2 for economy, 3 to display availibility, or 9 to exit.");
            }

            //if econ is not available checks if first class is

            else
            {
                if (seatACheck(arr, 'F') == false)
                {
                    Console.WriteLine("Sorry, no tickets are available. The next flight leaves in 3 hours");
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                    Console.WriteLine("Please enter 1 for first class, 2 for economy, 3 to display availibility, or 9 to exit.");
                }
                else
                {
                    string bookFirstClass;
                    Console.Write("There is no availablity in Economy class would you like to book a first class ticket?(Y/N):");
                    bookFirstClass = Console.ReadLine();
                    if (bookFirstClass.ToUpper() == "Y")
                        firstClass(arr);
                    else
                        Console.WriteLine("The next flight leaves in 3 hours.");
                }
                Console.WriteLine("Please enter 1 for first class, 2 for economy, 3 to display availibility, or 9 to exit.");
            }
        }
       
        public bool seatAvailable(char[,] array)
        {
            bool SeatAvailable = true;
            if (seatACheck(array, 'F') == false && seatACheck(array, 'E') == false)
            {
                SeatAvailable = false; //if seatAcheck fails to find a seat, validates all seats are filled and there is no availability
            }

            return SeatAvailable;
        }
    }
   


  