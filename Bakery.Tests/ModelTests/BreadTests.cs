using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBreadOrder = new Bread(12);
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }
    [TestMethod]
    public void GetLoafPrice_ReturnsLoafPrice_Int()
    {
      int thisLoaf = 5;
      Bread newBread = new Bread(1);
      int result = newBread.LoafPrice;
      Assert.AreEqual(thisLoaf, result);
    }
    [TestMethod]
    public void GetBreadTotal_ReturnTotalCost_Int()
    {
      int orderTotal = 10;
      Bread newBread = new Bread(2);
      newBread.BreadTotalCost = 10;
      int result = newBread.BreadTotalCost;
      Assert.AreEqual(orderTotal, result);
    }
    [TestMethod]
    public void CalculateBreadDiscount_CalculatesAndSetsDiscountPrice_Bread()
    {
      int thisDiscount = 25;
      Bread newBread = new Bread(15);
      newBread.CalculateBreadDiscount();
      int result = newBread.BreadDiscount;
      Assert.AreEqual(thisDiscount, result);
    }
    [TestMethod]
    public void CalculateBreadDiscount_CalculateTotalCostBasedOnDiscount_Bread()
    {
      int thisTotal = 50;
      Bread newBread = new Bread(15);
      newBread.CalculateBreadDiscount();
      int result = newBread.BreadTotalCost;
      Assert.AreEqual(thisTotal, result);
    }
  }
}

