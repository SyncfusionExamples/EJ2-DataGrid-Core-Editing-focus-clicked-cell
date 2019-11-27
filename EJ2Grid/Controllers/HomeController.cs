using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2Grid.Models;
using Syncfusion.EJ2.Base;
using System.Collections;

namespace EJ2Grid.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (order.Count == 0)
                BindDataSource();
            ViewBag.data = order;
            return View();
        }
		
        public void BindDataSource()
        {
            order.Add(new Orders(10248, 1, 1, "VINET", "Reims", 11.22));
            order.Add(new Orders(10249, 2, 2, "ALFKI", "Münster", 22.33));
            order.Add(new Orders(10250, 3, 3, "TOMSP", "Rio", 33.21));
            order.Add(new Orders(10251, 4, 4, "HANAR", "Lyon", 12.21));
            order.Add(new Orders(10252, 5, 5, "HILAA", "Resende", 44.12));
            order.Add(new Orders(10253, 6, 6, "CENTC", "Graz", 45.21));
            order.Add(new Orders(10254, 7, 7, "RICSU", "México", 21.43));
            order.Add(new Orders(10255, 8, 8, "ERNSH", "Oulu", 42.21));
        }
        public class Orders
        {
            public Orders()
            {

            }
            public Orders(int OrderID, int ShipID, int EmployeeID, string CustomerID, string City, double Freight)
            {
                this.OrderID = OrderID;
                this.ShipID = ShipID;
                this.EmployeeID = EmployeeID;
                this.CustomerID = CustomerID;
                this.City = City;
                this.Freight = Freight;
            }
            public int OrderID { get; set; }
            public int ShipID { get; set; }
            public int EmployeeID { get; set; }
            public string CustomerID { get; set; }
            public string City { get; set; }
            public double Freight { get; set; }
        }
    }
}

