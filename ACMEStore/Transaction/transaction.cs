using System;
//William Slocum Mist352
public class Transaction
{
    //autoimp name property
    public string Cusname { get; set; }


    // // constructor for user entered name
    public Transaction(string userName)
    {
        Cusname = userName;
    }

    //instance varibles for user inputted product code and quantity
    public int productamt = 0;
    public string productcode;
    
    //item quantity counter instance varibles
    int totalAA = 0, totalAD = 0, totalAH = 0, totalAC = 0, totalAM = 0;
    double aa = 19.99; // some local var for each product code and the associated cost
    double ad = 59.99;
    double ah = 20.50;
    double ac = 105.99;
    double am = 16.99;
    public void ProductShop() //method for the opening product shop and product ordering system
    {
        Console.WriteLine("Please choose form the following products by entering the product code followed by the quantity. Or enter Ctrl + z to exit:");

        Console.WriteLine("Product #   |  Product type             | Price  | Discount Qty |");
        Console.WriteLine("------------|---------------------------|--------|--------------|");
        Console.WriteLine("Product AA  |  Acme Anvil               | 19.99  |     60       |");
        Console.WriteLine("Product AD  |  Acme Dynamite            | 59.99  |     50       |");
        Console.WriteLine("Product AH  |  Acme Hi-Speed Tonic      | 20.50  |     50       |");
        Console.WriteLine("Product AC  |  Acme Crash Helmet        | 105.99 |     90       |");
        Console.WriteLine("Product AM  |  Acme Magnet              | 16.99  |     100      |");
        Console.WriteLine("------------|---------------------------|--------|--------------|");
        
    }
    
    public void CustomerCart()// handles product code and quantity
    {
        Console.WriteLine("product code: ");
        productcode = Console.ReadLine();
        while(productcode != null)
        {
            Console.WriteLine("Quantity: ");
            productamt = int.Parse(Console.ReadLine());

            if (productcode == "AA")
            {
                totalAA = totalAA + productamt;
            }
            else if (productcode == "AD")
            {
                totalAD = totalAD + productamt;
            }
            else if (productcode == "AH")
            {
                totalAH = totalAH + productamt;
            }
            else if (productcode == "AC")
            {
                totalAC = totalAC + productamt;
            }
            else if (productcode == "AM")
            {
                totalAM = totalAM + productamt;
            }
            Console.WriteLine("product code: ");
            productcode = Console.ReadLine();

        }


    }
    public void CustomerSubtotal() //calculates the total price of items
    {   //cost before discount
        decimal totalaa = totalAA * (decimal)aa;
        decimal totalad = totalAD * (decimal)ad;
        decimal totalah = totalAH * (decimal)ah;
        decimal totalac = totalAC * (decimal)ac;
        decimal totalam = totalAM * (decimal)am;

        //cost with discount
        decimal disAA = totalaa * (decimal).9;
        decimal disAD = totalad * (decimal).9;
        decimal disAH = totalah * (decimal).9;
        decimal disAC = totalac * (decimal).9;
        decimal disAM = totalam * (decimal).9;

        decimal total = 0;

        Console.WriteLine($"\nCustomer: {Cusname}"); 
        Console.WriteLine("\nItems ordered:");
        Console.WriteLine("\n Product num    |    Product Name    |     Price     |    Qty     |    Total  ");
        Console.WriteLine("--------------------------------------------------------------------------------");
        if (totalAA >0)
        {
            Console.WriteLine($"Product AA        ACME Anvil            @19.99      x{totalAA}            ${totalaa} ");
        }
        if (totalAA >= 60)
        {
            Console.WriteLine($"                                                 discounted price: ${disAA} ");
        }
        if (totalAD > 0)
        {
            Console.WriteLine($"Product AD        ACME Dynamite         @59.99      x{totalAD}            ${totalad} ");
        }
        if (totalAD >= 50)
        {
            Console.WriteLine($"                                                 discounted price: ${disAD} ");
        }
        if (totalAH > 0)
        {
            Console.WriteLine($"Product AH        ACME Hi-Speed Tonic   @20.50      x{totalAH}            ${totalah} ");
        }
        if (totalAH >= 50)
        {
            Console.WriteLine($"                                                 discounted price: ${disAH} ");
        }
        if (totalAC > 0)
        {
            Console.WriteLine($"Product AC        ACME Crash Helmet     @105.99     x{totalAC}             ${totalac} ");
        }
        if (totalAC >= 90)
        {
            Console.WriteLine($"                                                 discounted price: ${disAC} ");
        }
        if (totalAM > 0)
        {
            Console.WriteLine($"Product AM        ACME Magnet            @16.99      x{totalAM}            ${totalam} ");
        }
        if (totalAM >= 100) 
        {
            Console.WriteLine($"                                                 discounted price: ${disAM}  ");
        }

        if(totalAA >= 60)
        {
            total += disAA;
        }
        else
        {
            total += totalaa;
        }
        if (totalAD >= 50)
        {
            total += disAD;
        }
        else
        {
            total += totalad;
        }
        if (totalAH >= 50)
        {
            total += disAH;
        }
        else
        {
            total += totalah;
        }
        if (totalAC >= 90)
        {
            total += disAC;
        }
        else
        {
            total += totalac;
        }
        if (totalAM >= 60)
        {
            total += disAM;
        }
        else
        {
            total += totalam;
        }
        Console.WriteLine($"Invoice total: ${total}");
    }
    

}