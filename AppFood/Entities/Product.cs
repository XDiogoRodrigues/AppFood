using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AppFood.Entities
{
    abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
           
        }

        public override string ToString()
        {
            StringBuilder s1 = new StringBuilder();
            s1.AppendLine($"Name: {Name}, Price: R$ {Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {Quantity}");
            s1.Append($"Ingredients: ");
            return s1.ToString();
        }
    }
}
