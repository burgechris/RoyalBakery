namespace Bakery.Menu
{
  public class Pastry
  {
    public int PastryQty { get; set; }
    public int PastryPrice { get; set; }

    public Pastry(int pastryQty)
    {
      PastryQty = pastryQty;
      PastryPrice = 0;
    }

    public int CalcPastry(int pastryQty)
    {
      PastryPrice = ((pastryQty / 3) * 5) + (2 * (pastryQty % 3));
      return PastryPrice;
    }

    public int AddPastry(int pastryAdd)
    {
      PastryPrice += CalcPastry(pastryAdd);
      return PastryPrice;
    }
  }
}