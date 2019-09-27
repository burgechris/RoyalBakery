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
      if ((pastryQty % 2) == 0)
      {
        PastryPrice = pastryQty * 2;
      }
      else if((pastryQty % 2) == 1)
      {
        PastryPrice = ((pastryQty / 3) * 5) + (2 * (pastryQty % 3));
      }
      return PastryPrice;
    }
  }
}