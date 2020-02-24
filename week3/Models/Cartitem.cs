using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace week3.Models
{
    public class Cartitem
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }

        public Cartitem()
        {
        }

        public Cartitem(Product product , int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;

        }
        public String Display()
        { 
            return Quantity+"*"+Product.Name+ " at $"+Product.UnitPrice+" each = $"+Product.UnitPrice*Quantity;
        }
    }
}