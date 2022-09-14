﻿using BuiltInTagHelpersDemos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuiltInTagHelpersDemos.Controllers
{
    public class ProductController : Controller
    {
        private ProductData pData;

        public ProductController(ProductData cData)
        {
            pData = cData;
        }

        public IActionResult Index()
        {
            return View(pData.Products);
        }

        public IActionResult Details(int id)
        {
            return View(pData.Products.FirstOrDefault(a => a.ProductID == id));
        }

        [Route("/Product/ShowAllProducts",Name ="ListOfProducts")]
        public IActionResult ShowAllProducts()
        {
            return View(pData.Products);
        }
    }
}
