
using System;
using System.Collections.Generic;
using ShoppingLibrary;

namespace MyShoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            var item = new ShoppingCartItem("laptop", 10000);
            cart.AddShoppingItem(item);
            item = new ShoppingCartItem("television", 5000);
            cart.AddShoppingItem(item);
            item = new ShoppingCartItem("cellPhone", 2000);
            cart.AddShoppingItem(item);
            List<ShoppingCartItem> ShoppingCartItems = cart.CartList();

            foreach (ShoppingCartItem shoppingCartItem in ShoppingCartItems)
            {
                Console.WriteLine(_ = shoppingCartItem.Name + "\t\t\t" + shoppingCartItem.Price);
            }
            Console.WriteLine("Subtotal:" + "\t\t\t" + cart.GetSubTotal());
            Console.WriteLine("WithVat:" + "\t\t\t" + cart.GetSubTotalVat());



        }
    }
}
