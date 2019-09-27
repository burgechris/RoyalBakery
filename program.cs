using System;
using System.Collections.Generic;
using Bakery.Menu;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Our menu consists of two items.");
      Console.WriteLine("1. Bread: $5. Buy 2 loaves, get 1 free.");
      Console.WriteLine("We sell Marble Rye and Ciabatta.");
      Console.WriteLine("2. Pastry: $2 or 3 for $5.");
      Console.WriteLine("We sell pumkin scones and cheese danishes.");
      Console.WriteLine("What kind of bread would you like?");
      string breadFlavor = Console.ReadLine();
      Console.WriteLine("How many loaves of bread would you like?");
      int breadQty = int.Parse(Console.ReadLine());
      Console.WriteLine("What kind of pastry would you like?");
      string pastryFlavor = Console.ReadLine();
      Console.WriteLine("How many pastries would you like?");
      int pastryQty = int.Parse(Console.ReadLine());
    }
  }
}