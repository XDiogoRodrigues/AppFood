﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFood.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string[] Ingredients;

        public Product(string name, double price, int quantity, string[] listIngredients)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Ingredients = listIngredients;
        }
    }
}
