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
      PastryPrice = ((pastryQty / 3) * 5) + (2 * (pastryQty % 3));
      return PastryPrice;
    }
  }
}