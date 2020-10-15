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

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      Order newOrder1 = new Order("test Title", "test description", 5,  12);
      Order newOrder2 = new Order("test Title", "test description", 5,  12);
    
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
       Order newOrder1 = new Order("test Title", "test description", 5,  12);
       Order newOrder2 = new Order("test address", "test guitar", 2, 6);
       Order newOrder3 = new Order("test piano", "test bass", 4,  20);

      //Act
      int result = newOrder3.Id;

      //Assert
      Assert.AreEqual(3, result);
    }

  

  }
}