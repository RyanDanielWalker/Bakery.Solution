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
  }
}

