using System;
using System.Collections.Generic;

namespace Bakery.Menu
{
  public class Bread
  {
    public int BreadPrice { get; set; }

    public Bread()
    {
      BreadPrice = 0;
    }

    public int CalcBread(int breadQty)
    {
      if (breadQty == 1)
      {
        BreadPrice = 5;
      }
      else
      {
        BreadPrice = ((breadQty / 3) * (5 * 2)) + (5 * (breadQty % 3));
      }
      return BreadPrice;
    }
  }
}