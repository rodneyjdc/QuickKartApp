using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Library.Models
{
    public class Cart
    {
        public ArrayList Products { get; set; }

        public Cart()
        {
            this.Products = new ArrayList();
        }

        public void AddToCart(Product product)
        {
            this.Products.Add(product);
        }

        public void RemoveFromCart(Product productToRemove)
        {
            this.Products.Remove(productToRemove);
        }

        public ArrayList GetCartProductDetails()
        {
            return this.Products;
        }

        public string GetCartDetails()
        {
            int capacity = this.Products.Capacity;
            int count = this.Products.Count;

            string details = string.Empty;
            details += "Cart Capacity = " + capacity;
            details += "\nProducts Count = " + count;

            return details;
        }
    }
}
