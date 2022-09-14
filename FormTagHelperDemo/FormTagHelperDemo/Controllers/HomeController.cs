using FormTagHelperDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FormTagHelperDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Category objCategory = new Category();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Categories = objCategory.Categories;
            return View();
        }

        [HttpPost]
        public IActionResult Index(Product product)
        {
            //Bind Include Syntax public IActionResult Index([Bind("Cost","Quantity","CategoryID","ProductName")] Product prod)

            ViewBag.Categories = objCategory.Categories;
            ModelState.Clear();
            product.BillAmount = product.Cost * product.Quantity;
            if(product.BillAmount > 10000 && product.IsPartOfDeal)
            {
                product.Discount = product.BillAmount * 10 / 100;
            }
            else
            {
                product.Discount = product.BillAmount * 5 / 100;
            }
            product.NetBillAmount = product.BillAmount - product.Discount;

            switch (product.CategoryID)
            {
                case 1:
                case 2:
                    product.NetBillAmount -= 1000;
                    break;
            }

            return View(product);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
