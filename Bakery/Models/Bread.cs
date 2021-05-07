using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int LoafPrice { get; set; }
    public int TotalCost { get; set; }
    public int LoavesOrdered { get; set; }
    public int FreeLoaves { get; set; }


    // public Bread(int loavesOrdered)
    // {
    //   // 
    // }

    public int GetLoafPrice()
    {
      return LoafPrice;
    }

    public int GetBreadTotal()
    {
      return TotalCost;
    }
    public void CalculateFreeLoaves()
    {
      FreeLoaves = LoavesOrdered / 3;
      if (FreeLoaves % 1 == 0)
      {
        TotalCost -= (FreeLoaves * 5);
      }
    }





  }
}
