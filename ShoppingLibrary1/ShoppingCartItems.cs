﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class ShoppingCartItem
    {
        private string _name;
        private double _price;
        public ShoppingCartItem(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}

















