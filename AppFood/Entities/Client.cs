using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFood.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public ShoppingCart Cart { get; set; }

        public Client(string name, string phone, string address, ShoppingCart cart)
        {
            Name = name;
            Phone = phone;
            Address = address;
            Cart = cart;
        }

        public void AddProductToCart(Product product)
        {
            Cart.products.Add(product);
        }

        public void RemoveProductToCart(Product product)
        {
            Cart.products.Remove(product);
        }
    }
}
