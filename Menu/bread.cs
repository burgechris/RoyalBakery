namespace Bakery.Menu
{
  public class Bread
  {
    public int BreadQty { get; set; }
    public int BreadPrice { get; set; }

    public Bread(int breadQty)
    {
      BreadQty = breadQty;
      BreadPrice = 0;
    }

    public int CalcBread(int breadQty)
    {
      BreadPrice = ((5 * (breadQty % 3)) + (breadQty / 3) * 10);
      return BreadPrice;
    }

    public int AddBread(int breadAdd)
    {
      BreadPrice += CalcBread(breadAdd);
      return BreadPrice;
    }
  }
}