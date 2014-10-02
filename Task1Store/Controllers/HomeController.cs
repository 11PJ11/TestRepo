using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Task1Store.Models;

namespace Task1Store.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult PostCustomer(Customer data)
        {
            return Json(data);
        }
        public ViewResult PostCustomerView()
        {
            Customer[] customers ={
                                   new Customer{  Id="customer-001",Name="Markvald Huset",Born= "1980-02-07T11:00:00+2",City="Stavanger",Country="Norway"},
                                   new Customer{  Id="customer-002",Name="John Smith",Born= "1977-12-18T11:00:00+2",City="London",Country="United Kingdom"}
                                  };
            return View(customers);

        }
	}
}