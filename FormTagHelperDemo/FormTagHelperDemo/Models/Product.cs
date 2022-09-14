using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FormTagHelperDemo.Models
{
    public class Product
    {
        [BindNever]
        public int ProductID { get; set; }

        [BindNever]
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        [DisplayFormat(DataFormatString = "{0:c2}", ApplyFormatInEditMode = true)]
        public decimal Cost { get; set; }
        public decimal? BillAmount { get; set; }
        public decimal? Discount { get; set; }
        public decimal? NetBillAmount { get; set; }
        public bool IsPartOfDeal { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public string PaymentType { get; set; }
    }
}
