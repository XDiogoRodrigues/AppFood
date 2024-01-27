using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFood.Entities
{
    class Order
    {
        public int NumberOrder { get; set; }
        public Client ClientOrder { get; set; }
        public string Observation { get; set; }
        public List<Product> products = new List<Product>();
        public ShoppingCart CartProducts { get; set; }

        public Order(int numberOrder, Client clientOrder, string observation, ShoppingCart cart)
        {
            NumberOrder = numberOrder;
            ClientOrder = clientOrder;
            Observation = observation;
            CartProducts = cart;
        }



    }
}
