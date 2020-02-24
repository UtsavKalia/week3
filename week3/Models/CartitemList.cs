using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace week3.Models
{
    public class CartitemList
    {
        private List<Cartitem> cartItems;

        public CartitemList()
        {
            cartItems = new List<Cartitem>();
        }
        public void AddItem(Product product, int quantity)
        {
            Cartitem myCartItem = new Cartitem(product, quantity);
            cartItems.Add(myCartItem);
        }
        public void RemoveAt(int index)
        {
            cartItems.RemoveAt(index);
        }
        public void Clear()
        {
            cartItems.Clear();
        }
        public int Count()
        {
            return cartItems.Count;
        }
        public Cartitem itemAt(int index) {

            return cartItems.ElementAt(index);
        }



    } 
}