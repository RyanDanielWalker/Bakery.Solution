using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int LoafPrice { get; set; }
    public int BreadTotalCost { get; set; }
    public int LoavesOrdered { get; set; }
    public int BreadDiscount { get; set; }

    public Bread(int loavesOrdered)
    {
      LoavesOrdered = loavesOrdered;
      LoafPrice = 5;
      BreadTotalCost = 0;
      BreadDiscount = 0;
    }
    public int GetLoafPrice()
    {
      return LoafPrice;
    }
    public int GetBreadTotal()
    {
      return BreadTotalCost;
    }
    public void CalculateBreadDiscount()
    {
      int discountLoaves = LoavesOrdered / 3;
      BreadDiscount = discountLoaves * 5;
      BreadTotalCost = (LoavesOrdered * LoafPrice) - BreadDiscount;
    }

  }

}

