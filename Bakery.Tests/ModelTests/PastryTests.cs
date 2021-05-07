using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(15);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetPastryPrice_ReturnsPastryPrice_Int()
    {
      int thisPastry = 2;
      Pastry newPastry = new Pastry(1);
      int result = newPastry.GetPastryPrice();
      Assert.AreEqual(thisPastry, result);
    }
    [TestMethod]
    public void GetPastryTotal_ReturnPastryTotalCost_Int()
    {
      int pastryTotal = 8;
      Pastry newPastry = new Pastry(4);
      newPastry.PastryTotalCost = 8;
      int result = newPastry.GetPastryTotal();
      Assert.AreEqual(pastryTotal, result);
    }
    [TestMethod]
    public void CalculatePastryDiscount_CalculateAndSetDiscountPrice_Pastry()
    {
      int pastryDiscount = 5;
      Pastry newPastry = new Pastry(15);
      newPastry.CalculatePastryDiscount();
      int result = newPastry.PastryDiscount;
      Assert.AreEqual(pastryDiscount, result);
    }
    [TestMethod]
    public void CalculatePastryDiscount_CalculatePastryTotalCostBasedOnDiscount_Pastry()
    {
      int pastryTotal = 25;
      Pastry newPastry = new Pastry(15);
      newPastry.CalculatePastryDiscount();
      int result = newPastry.PastryTotalCost;
      Assert.AreEqual(pastryTotal, result);
    }
  }
}




