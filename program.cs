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
      Console.WriteLine("Here is our bread menu:");
      Console.WriteLine("1. Chocolate Babka: $5/loaf");
      Console.WriteLine("2. Cinammon Babka: $5/loaf");
      Console.WriteLine("3. Marble Rye: $5/loaf");
      Console.WriteLine("All bread is Buy 2, get one free.");
      Console.WriteLine("Please enter the quantity of breads you would like.");

      string userInput = Console.ReadLine();
      if(int.TryParse(userInput, out int breadQty))
      {
        // int breadQty = int.Parse(userInput);
        Bread breadOrder = new Bread();
        int bTotal = breadOrder.CalcBread(breadQty);
      }
      else
      {
        Console.WriteLine("Please enter a valid quantity.");
      } 

      Console.WriteLine("1. Black and White Cookie: $2 for 1 or 3 for $5.");
      Console.WriteLine("---------------------------");
      Console.WriteLine("How many loaves of marble rye would you like?");

      Console.WriteLine("How many cookies would you like?");

      int pastryQty = int.Parse(Console.ReadLine());
      Pastry pastryOrder = new Pastry();
      int pTotal = pastryOrder.CalcPastry(pastryQty);

      Console.WriteLine("---------------------------");
      Console.WriteLine("Thank you for your order, " + custName + ". Your total is $" + (bTotal + pTotal) + ".");
    }
  }
}