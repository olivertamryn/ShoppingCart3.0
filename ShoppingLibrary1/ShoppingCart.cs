using System;
using System.Collections.Generic;

namespace ShoppingLibrary
{
    public class ShoppingCart
    {
        private List<ShoppingCartItem> _items = new List<ShoppingCartItem>();
        private List<ShoppingCartItem> _ShoppingItems;
        public void AddShoppingItem(ShoppingCartItem item)
        {
            _items.Add(item);
        }
        public List<ShoppingCartItem> CartList()
        {
            return _items;
        }
        public double GetSubTotal()
        {
            double total = 0;
            foreach (ShoppingCartItem item in _items)
            {
                total += item.Price;
            }
            return Math.Round(total, 2);
        }
        public double GetSubTotalVat()
        {
            double totalwithVAT = 0.15;
            totalwithVAT = GetSubTotal() + GetSubTotal();
            return Math.Round(totalwithVAT, 2);
        }
    }
}
