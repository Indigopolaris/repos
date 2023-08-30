using System;

namespace MakerOfThings
{
    internal class Entryside
    {
        public static void Main()
        {
           Console.WriteLine("tryout my shape maker");
           Console.WriteLine("Pick a number from the list the corresponds to the shape you want or enter 0 to exit.");
           Console.WriteLine("Shape List:");
           Console.WriteLine("--------------");
           Console.WriteLine("Square = 1");
           Console.WriteLine("Triangle = 2");
           Console.WriteLine("Circle = 3");
           Console.WriteLine("Octagon = 4");
           Console.WriteLine("");

            int requests = 1;
            while(requests > 0)
            {
                int shapeNumber = int.Parse(Console.ReadLine());

                ShapeMaker Connector = new ShapeMaker(shapeNumber);

                if (shapeNumber == 1)
                {
                    Connector.Square();

                }
                else if (shapeNumber == 2)
                {
                    Connector.Triangle();

                }
                else if (shapeNumber == 3)
                {
                    Connector.Circle();

                }
                else if (shapeNumber == 4)
                {
                    Connector.Octagon();

                }
                else
                {
                    return;
                    
                }
            }    
        }
    }
}
