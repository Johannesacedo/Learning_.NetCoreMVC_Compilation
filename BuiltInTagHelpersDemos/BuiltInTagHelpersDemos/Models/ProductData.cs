using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuiltInTagHelpersDemos.Models
{
    public class ProductData
    {
        private List<Product> _Products = new List<Product>
        {
            new Product
            {
                ProductID =1,
                ProductName = "AMD Ryzen 3990",
                Quantity = 100,
                UnitsInStock = 50,
                Discontinued = false,
                Cost = 3000,
                LaunchDate = new DateTime(2019,10,1)
            },
            new Product
            {
                ProductID =2,
                ProductName = "AMD Ryzen 3991",
                Quantity = 100,
                UnitsInStock = 45,
                Discontinued = false,
                Cost = 3000,
                LaunchDate = new DateTime(2019,10,1)
            },
            new Product
            {
                ProductID =3,
                ProductName = "AMD Ryzen 3992",
                Quantity = 100,
                UnitsInStock = 50,
                Discontinued = false,
                Cost = 3000,
                LaunchDate = new DateTime(2019,10,1)
            },
            new Product
            {
                ProductID =4,
                ProductName = "AMD Ryzen 3993",
                Quantity = 100,
                UnitsInStock = 45,
                Discontinued = false,
                Cost = 3000,
                LaunchDate = new DateTime(2019,10,1)
            }
        };
        public IEnumerable<Product> Products => _Products;
    }
}
