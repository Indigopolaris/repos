using System; 


public class ShapeMaker
{
    public int shapeNum { get; set; }

    public ShapeMaker(int shapeNumber)
    {
        shapeNum = shapeNumber;
    }
    public void Square()
    {
        Console.WriteLine("----------------");
        Console.WriteLine("|               |\n|               |\n|               |\n|               |\n|               |\n|               |\n|               |\n");
        Console.WriteLine("----------------");
        Console.WriteLine(" ");
    }
    public void Triangle()
    {
        Console.WriteLine("       ^");
        Console.WriteLine("      ^ ^");
        Console.WriteLine("     ^   ^");
        Console.WriteLine("    ^     ^");
        Console.WriteLine("   ^       ^");
        Console.WriteLine("  ^         ^");
        Console.WriteLine(" ^           ^");
        Console.WriteLine(" -------------");
        Console.WriteLine(" ");

    }
    public void Circle()
    {
        Console.WriteLine("      oooooooooo");
        Console.WriteLine("    oo          oo");
        Console.WriteLine("  oo              oo");
        Console.WriteLine("oo                  oo");
        Console.WriteLine("oo                  oo");
        Console.WriteLine("oo        oo        oo");
        Console.WriteLine("oo                  oo");
        Console.WriteLine("oo                  oo");
        Console.WriteLine("  oo              oo");
        Console.WriteLine("    oo          oo");
        Console.WriteLine("      oooooooooo");
        Console.WriteLine(" ");
    }
    public void Octagon()
    {
        Console.WriteLine("          ##########");
        Console.WriteLine("        ##          ##");
        Console.WriteLine("      ##              ##");
        Console.WriteLine("    ##                  ##");
        Console.WriteLine("  ##                      ##");
        Console.WriteLine("  ##                      ##");
        Console.WriteLine("  ##                      ##");
        Console.WriteLine("  ##                      ##");
        Console.WriteLine("  ##                      ##");
        Console.WriteLine("    ##                  ##");
        Console.WriteLine("      ##              ##");
        Console.WriteLine("        ##          ##");
        Console.WriteLine("          ##########");
        Console.WriteLine(" ");
    }
}