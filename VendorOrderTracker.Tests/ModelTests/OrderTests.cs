using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;
namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test Title", "test description", 5,  12);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
       Order newOrder = new Order("test Title", "test description", 5,  12);

      //Act
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual("test Title", result);
    }
    [TestMethod]
    public void SetPrice_SetPrice_String()
    {
      //Arrange
      Order newOrder = new Order("test Title", "test description", 5,  12);

      //Act
      int updatedPrice = 10;
      newOrder.Price = updatedPrice;
      int result = newOrder.Price;

      //Assert
      Assert.AreEqual(updatedPrice, result);
    }
  

  }
}