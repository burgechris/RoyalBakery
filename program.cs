using System;
using System.Collections.Generic;
using Bakery.Menu;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Royal Bakery!");
      Console.WriteLine("---------------------------");
      Console.WriteLine("What is your name?");
      string custName = Console.ReadLine();
      Console.WriteLine("---------------------------");
      Console.WriteLine("Here is our menu:");
      Console.WriteLine("--Chocolate Babka: $5/loaf or buy 2, get one free--");
      Console.WriteLine("--Black and White Cookie: $2 for 1 or 3 for $5--");
      Console.WriteLine("---------------------------");
      Console.WriteLine("Please enter the number of bread loaves you would like.");

      int breadQty = int.Parse(Console.ReadLine());
      Bread breadOrder = new Bread();
      int bTotal = breadOrder.CalcBread(breadQty);

      Console.WriteLine("Please enter the number of cookies would you like.");

      int pastryQty = int.Parse(Console.ReadLine());
      Pastry pastryOrder = new Pastry();
      int pTotal = pastryOrder.CalcPastry(pastryQty);

      Console.WriteLine("---------------------------");
      Console.WriteLine("Would you like to add anything else? [press Y' for yes or 'N' for No]");
      string userAdd = Console.ReadLine();
      if(userAdd == "y" || userAdd == "Y")
      {
        Console.WriteLine("What would you like to add? [press '1' for bread or '2' for pastry or '3' for both]");
        string userAddItem = Console.ReadLine();
        if(userAddItem == "1")
        {
          addBread();
        }
        else if(userAddItem == "2")
        {
          addPastry();
        }
        else if(userAddItem == "3")
        {
          addBoth();
        }
      }
      else if(userAdd == "n" || userAdd == "N")
      {
        Console.WriteLine("Thank you for your order, " + custName + ". Your total is $" + (bTotal + pTotal) + ".");
      } 
    }
  }
}