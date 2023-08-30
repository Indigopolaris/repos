namespace Reservation
{

    public class ReservationTest
    {
        public static void Main()
        {

            char[,] charAvailableSeats = new char[10, 2];

            SeatReservation testReservation = new SeatReservation(charAvailableSeats);  // seat obj initalization
            testReservation.seatUserPrompt();

            //fills the seats
            for (int i = 0; i < 10; i++)
            {
                //turns the seats to 'A'
                charAvailableSeats[i, 0] = 'A';
                charAvailableSeats[i, 1] = 'A';
            }

            int UserInput;
            while (true) // insures the user inputs something so the code can continue
            {
                
                UserInput = int.Parse(Console.ReadLine()); // calls methods based on user input, either filling seats or displaying available seats
                switch (UserInput)
                {
                    default:

                        Console.WriteLine("\nPlease enter a valid number 1,2, or 3: ");
                        break;

                    case 1:
                        testReservation.firstClass(charAvailableSeats); // calls each method based on user input
                        break;

                    case 2:
                        testReservation.economyClass(charAvailableSeats);
                        break;

                    case 3:
                        testReservation.SeatUserDisplay(charAvailableSeats);
                        break;

                    case 9:

                        Environment.Exit(0); //exits program if 9 is entered 
                        break;


                }

            }

        }

    }


}      
        


