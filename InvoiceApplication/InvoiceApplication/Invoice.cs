// Mist 352 Assignment 3
//William Slocum

using System;
public class Invoice
{
    decimal invTotal;
    string invoiceString;
    int productcode;
    float productqty = 0;

    float product1total;
    float product2total;
    float product3total;
    float product4total;
    float product5total;

    string customerName { get; set; } // auto implemented name property
    public Invoice(string CustomerName) //constructor for name property
    {
        customerName = CustomerName;
    }

    public void DisplayMessage() // displays item menu for the customer
    {
        Console.WriteLine("Please choose from the following products by entering the product code \n followed by quantity. Enter <ctrl> z to exit:");
        Console.WriteLine("");
        Console.WriteLine("Product 1 - Kona Blend          - $14.95");
        Console.WriteLine("Product 2 - Cafe Verona         - $ 9.95");
        Console.WriteLine("Product 3 - Espresso Roast      - $ 9.90");
        Console.WriteLine("Product 4 - French Roast        - $10.45");
        Console.WriteLine("Product 5 - Organic shade Grown - $13.45");

    }

    public void AddItem() // accepts the product code and quantity then calculates the totals for each item
    {

        Console.WriteLine("Please enter product code <1,2,3,4, or 5> follwed by qty on the next line:");

        productcode = int.Parse(Console.ReadLine());
        while (productcode != null)  //null as sentinel while loop to collect product codes and quantities
        {
         
          if (productcode == 1 )
          {

            productqty = float.Parse(Console.ReadLine());
                
          }

          else if (productcode == 2 )
          {
            productqty = Convert.ToInt32(Console.ReadLine());
                
          }

          else if (productcode == 3)
          {
           productqty = Convert.ToInt32(Console.ReadLine());
                
          }

          else if (productcode == 4)
          {
           productqty = Convert.ToInt32(Console.ReadLine());
                
          }
          else if(productcode == 5)
          {
           productqty = Convert.ToInt32(Console.ReadLine());
                
          }

          productcode = int.Parse(Console.ReadLine());
          
        }

        product1total = (float)14.95 * productqty;  //calculates the the item total from price*qty
        product2total = (float)9.95 * productqty;
        product3total = (float)9.90 * productqty;
        product4total = (float)10.45 * productqty;
        product5total = (float)13.45 * productqty;

        //calculates the final total of all items purchased
        invTotal = (decimal)product1total + (decimal)product2total + (decimal)product3total + (decimal)product4total + (decimal)product5total;
    } 

    public void DisplayTotals() // displays the total strings for each item purchased, as well as the price and qty of each item for the customer to view
    {
        Console.WriteLine($"Customer Name: {customerName}");

        if(productcode == 1)
        {
            Console.WriteLine($"Product 1 - Kona Blend         @ $14.95 * {productqty} = ${product1total:F}"); //invoice strings for the item if it was ordered
        }
        else if (productcode == 2)
        {
            Console.WriteLine($"Product 2 - Cafe Verona        @ $ 9.95 * {productqty} = ${product2total:F}");
        }
        else if (productcode == 3)
        {
            Console.WriteLine($"Product 3 - Espresso Roast     @ $ 9.90 * {productqty} = ${product3total:F}");
        }
        else if (productcode == 4)
        {
            Console.WriteLine($"Product 4 - Cafe Verona        @ $10.45 * {productqty} = ${product4total:F}");
        }
        else if (productcode == 5)
        {
            Console.WriteLine($"Product 5 - Cafe Verona        @ $13.45 * {productqty} = ${product5total:F}");
        }
        Console.WriteLine($"Invoice Total: {invTotal}"); //displays the final total
    }
}
