using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test name", "test description", "test phone");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetPhone_ReturnsPhone_Int()
    {
      //Arrange
      Vendor newVendor = new Vendor("test name", "test description", "test phone");
      //Act
      string result = newVendor.Phone;
      //Assert
      Assert.AreEqual("test phone", result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      Vendor newVendor = new Vendor("test name", "test description", "test phone");
      //Act
      int result = newVendor.Id;
      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      Vendor newVendor = new Vendor("test name", "test description", "test phone");
      Vendor newVendor1 = new Vendor("test Edu", "test bouyon", "test numero");
      List<Vendor> newList = new List<Vendor> { newVendor, newVendor1 };
      //Act
      List<Vendor> result = Vendor.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      Vendor newVendor1 = new Vendor("test name", "test description", "test phone");
      Vendor newVendor2 = new Vendor("test name", "test description", "test phone");
      Vendor newVendor3 = new Vendor("test name", "test description", "test phone");
      Vendor newVendor4 = new Vendor("test name", "test description", "test phone");
      //Act
      Vendor result = Vendor.Find(4);
      //Assert
      Assert.AreEqual(newVendor4, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      Order newOrder = new Order("test Title", "test description", 5,  "test date");
      List<Order> newList = new List<Order> { newOrder };
      Vendor newVendor = new Vendor("test name", "test description", "test phone");
      newVendor.AddOrder(newOrder);
      //Act
      List<Order> result = newVendor.Orders;
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
