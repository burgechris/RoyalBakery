using System;
using System.Collections.Generic;
using Bakery.Menu.Bread;
using Bakery.Menu.Pastry;

namespace Bakery.Menu.Order
{
  public class Order
  {
    public string Name { get; set; }
    public int Total { get; set; }

    public void Order(string name)
    {
      Name = name;
      Total = 0;
    }

    public int CalcTotal(int bTotal, int pTotal)
    {
      Total = bTotal + pTotal;
      return Total;
    }
  }
}