using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentsDemo.Models;

namespace ViewComponentsDemo.Components
{
    public class ProductSummary: ViewComponent
    {
        private ProductData data;

        public ProductSummary(ProductData pdata)
        {
            data = pdata;
        }

        //public string Invoke()
        //{
        //    return $"{data.Products.Count()} Products, " + $"{data.Products.Sum(c => c.Cost)} Worth of Stock";
        //}

        //public IViewComponentResult Invoke()
        //{
        //    return View(new ProductViewModel { 
        //        ProductsCount = data.Products.Count(),
        //        StockWorth = data.Products.Sum(c=>c.Cost)
        //    });
        //}

        public IViewComponentResult Invoke(int Units)
        {
            return View(new ProductViewModel
            {
                ProductsCount = data.Products.Where(n=>n.UnitsInStock >=Units).Count(),
                StockWorth = data.Products.Where(n=> n.UnitsInStock >=Units).Sum(c=>c.Cost)
            });
        }
    }
}
