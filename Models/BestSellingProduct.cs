using CloudyShop.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudyShop.Models
{
    public class BestSellingProduct
    {
        public Product Product { get; set; }
        public int TotalQuantitySold { get; set; }
    }
}