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
      int result = newPastry.PastryPrice;
      Assert.AreEqual(thisPastry, result);
    }

  }
}

