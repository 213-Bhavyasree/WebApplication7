using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            IList<Customer> customers = new List<Customer>();
            customers.Add(new Customer() { ID = 213, CustomerName = "Bhavya", CustomerAddress = "Kadapa" });
            customers.Add(new Customer() { ID = 214, CustomerName = "Kavya", CustomerAddress = "guntur" });
            customers.Add(new Customer() { ID = 215, CustomerName = "lavanvya", CustomerAddress = "nellore" });

            ViewData["customers"] = customers;

            return View();
        }
    }
}
