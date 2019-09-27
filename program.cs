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
      Console.WriteLine("Here is our menu:");
      Console.WriteLine("1. Chocolate Babka: $5 for 1 loaf. Buy 2 loaves, get 1 free.");
      Console.WriteLine("2. Black and White Cookie: $2 for 1 or 3 for $5.");
      Console.WriteLine("---------------------------");
      Console.WriteLine("How many loaves of marble rye would you like?");

      int breadQty = int.Parse(Console.ReadLine());
      Bread breadOrder = new Bread();
      int bTotal = breadOrder.CalcBread(breadQty);

      Console.WriteLine("How many cookies would you like?");

      int pastryQty = int.Parse(Console.ReadLine());
      Pastry pastryOrder = new Pastry();
      int pTotal = pastryOrder.CalcPastry(pastryQty);

      Console.WriteLine("---------------------------");
      Console.WriteLine("Thank you for your order, " + custName + ". Your total is $" + (bTotal + pTotal) + ".");
    }
  }
}