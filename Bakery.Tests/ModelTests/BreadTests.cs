using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearAll();
    }

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
      int result = newBread.GetLoafPrice();
      Assert.AreEqual(thisLoaf, result);
    }
    [TestMethod]
    public void GetBreadTotal_ReturnBreadTotalCost_Int()
    {
      int breadTotal = 10;
      Bread newBread = new Bread(2);
      newBread.BreadTotalCost = 10;
      int result = newBread.GetBreadTotal();
      Assert.AreEqual(breadTotal, result);
    }
    [TestMethod]
    public void CalculateBreadDiscount_CalculatesAndSetsDiscountPrice_Bread()
    {
      int breadDiscount = 25;
      Bread newBread = new Bread(15);
      newBread.CalculateBreadDiscount();
      int result = newBread.BreadDiscount;
      Assert.AreEqual(breadDiscount, result);
    }
    [TestMethod]
    public void CalculateBreadDiscount_CalculateTotalCostBasedOnDiscount_Bread()
    {
      int breadTotal = 50;
      Bread newBread = new Bread(15);
      newBread.CalculateBreadDiscount();
      int result = newBread.BreadTotalCost;
      Assert.AreEqual(breadTotal, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_BreadList()
    {
      List<Bread> newList = new List<Bread> { };
      List<Bread> result = Bread.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsBread_BreadList()
    {
      int loavesOrdered = 14;
      int loavesOrdered2 = 14;
      Bread newBread = new Bread(loavesOrdered);
      Bread newBread2 = new Bread(loavesOrdered2);
      List<Bread> newList = new List<Bread> { newBread, newBread2 };
      List<Bread> result = new List<Bread> { };
      CollectionAssert.AreEqual(newList, result);
    }
  }
}


