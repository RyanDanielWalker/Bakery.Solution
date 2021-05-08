using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Pastry.ClearAll();
    }
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(15);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetPastryDiscount_ReturnsPastryDiscount_Int()
    {
      int thisPastryDiscount = 2;
      Pastry newPastry = new Pastry(6);
      newPastry.PastryDiscount = 2;
      int result = newPastry.GetPastryDiscount();
      Assert.AreEqual(thisPastryDiscount, result);
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
    [TestMethod]
    public void GetAll_ReturnsEmptyList_PastryList()
    {
      List<Pastry> newList = new List<Pastry> { };
      List<Pastry> result = Pastry.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsPastry_PastryList()
    {
      int pastriesOrdered = 12;
      int pastriesOrdered2 = 12;
      Pastry newPastry = new Pastry(pastriesOrdered);
      Pastry newPastry2 = new Pastry(pastriesOrdered2);
      List<Pastry> newPastryList = new List<Pastry> { newPastry, newPastry2 };
      List<Pastry> result2 = Pastry.GetAll();
      CollectionAssert.AreEqual(newPastryList, result2);
    }
  }
}




