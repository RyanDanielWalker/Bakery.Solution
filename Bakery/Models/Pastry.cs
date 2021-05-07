using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryPrice { get; set; }
    public int PastryTotalCost { get; set; }
    public int PastriesOrdered { get; set; }
    public int PastryDiscount { get; set; }

    public Pastry(int pastriesOrdered)
    {
      PastriesOrdered = pastriesOrdered;
      PastryPrice = 2;
      PastryTotalCost = 0;
      PastryDiscount = 0;
    }
    public int GetPastryPrice()
    {
      return PastryPrice;
    }
    public int GetPastryTotal()
    {
      return PastryTotalCost;
    }
  }
}