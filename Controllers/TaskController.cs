using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Views.Models;

namespace Views.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult SprintTasks()
        {
            return View();
        }

        public IActionResult Greetings()
        {
            return View();
        }

        public IActionResult ProductInfo()
        {
            return View();
        }

        public IActionResult SuperMarkets()
        {
            ViewBag.Supermarkets = new List<string> { "WellMart", "Silpo", "ATB", "Furshet", "Metro" };
            return View();
        }

        public IActionResult ShoppingList()
        {
            var productsDict = new Dictionary<string, int>
            {
                { "Milk", 2 },
                { "Bread", 2 },
                { "Cake", 1 },
                { "Ice Cream", 5 },
                { "Cola", 10 }
            };
            return View(productsDict);
        }

        [HttpGet]
        public IActionResult ShoppingCart()
        {
            ViewBag.Supermarkets = new List<string> { "WellMart", "Silpo", "ATB", "Furshet", "Metro" };
            ViewBag.Products = new List<string> { "Bread", "Milk", "Cheese", "Sausage" };
            return View();
        }

        [HttpPost]
        public IActionResult ShoppingCart(string fullname, string address, string supermarket, string shippingDate, string[] selectedProducts)
        {
            ViewBag.Message = $"Your products will be shipped at: {address}. Bon appetite, {fullname}!";
            return View();
        }
    }
}