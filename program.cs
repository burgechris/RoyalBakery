using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Our menu consists of two items.");
      Console.WriteLine("1. Bread: $5. Buy 2 loaves, get 1 free.");
      Console.WriteLine("2. Pastry: $2 or 3 for $5.");
      Console.WriteLine("What would you like? [Press 1 for Bread or 2 for Pastry.");
      string userOrder = Console.ReadLine();
    }
  }
}