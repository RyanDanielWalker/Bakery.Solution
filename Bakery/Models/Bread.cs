using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int LoafPrice { get; set; }
    public int TotalCost { get; set; }
    public int LoavesOrdered { get; set; }
    // public int FreeLoaves { get; set; }
    public int Discount { get; set; }


    public Bread(int loavesOrdered)
    {
      LoavesOrdered = loavesOrdered;
      LoafPrice = 5;
      TotalCost = 0;
      Discount = 0;
    }

    public int GetLoafPrice()
    {
      return LoafPrice;
    }

    public int GetBreadTotal()
    {
      return TotalCost;
    }
    public void CalculateDiscount()
    {
      int theseLoaves = LoavesOrdered / 3;
      if (theseLoaves % 1 == 0)
      {
        Discount = theseLoaves * 5;
        TotalCost = (LoavesOrdered * LoafPrice) - Discount;
      }
      else
      {
        Discount = Math.Floor(theseLoaves);
      }








    }
  }
}
