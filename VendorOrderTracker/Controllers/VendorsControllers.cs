using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName,  string vendorDescription, string phoneNumber)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription,phoneNumber);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{vendorId}")]
    public ActionResult Show(int vendorId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(vendorId);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }


    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string title, string description, int price, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(title, description, price, orderDate);
      selectedVendor.AddOrder(newOrder);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", selectedVendor);
      return View("Show", model);
    }
    [HttpPost("/vendors/{vendorId}")]
    public ActionResult Patch(int vendorId, string vendorName, string vendorDescription, string phoneNumber)
    {
      Vendor selectedVendor = Vendor.Find(vendorId);
      selectedVendor.Name = vendorName;
      selectedVendor.Description = vendorDescription;
      selectedVendor.Phone = phoneNumber;
      return RedirectToAction("Show");
    }
  }
}