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
      Vendor newVendor = new Vendor("test name", "test description", 123);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetPhone_ReturnsPhone_Int()
    {
      //Arrange
      Vendor newVendor = new Vendor("test name", "test description", 123);

      //Act
      int result = newVendor.Phone;

      //Assert
      Assert.AreEqual(123, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      Vendor newVendor = new Vendor("test name", "test description", 123);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

     [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      Vendor newVendor = new Vendor("test name", "test description", 123);
      Vendor newVendor1 = new Vendor("test Edu", "test bouyon", 1234);
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
      Vendor newVendor1 = new Vendor("test name", "test description", 123);
      Vendor newVendor2 = new Vendor("test name", "test description", 123);
      Vendor newVendor3 = new Vendor("test name", "test description", 123);
      Vendor newVendor4 = new Vendor("test name", "test description", 123);

      //Act
      Vendor result = Vendor.Find(4);

      //Assert
      Assert.AreEqual(newVendor4, result);
    }





    
  }
}
