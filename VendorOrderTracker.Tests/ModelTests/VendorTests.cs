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



    
  }
}
