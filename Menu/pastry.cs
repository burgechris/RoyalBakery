using System;
using System.Collections.Generic;

namespace Bakery.Menu
{
  public class Pastry
  {
    public int PastryPrice { get; set; }

    public Pastry()
    {
      PastryPrice = 0;
    }

    public int CalcPastry(int pastryQty)
    {
      if (pastryQty == 1)
      {
        PastryPrice = 2;
      }
      else
      {
        PastryPrice = pastryQty / 2 * 5;
      }
      return PastryPrice;
    }
  }
}