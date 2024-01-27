using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace AppFood.Entities
{
    class Order
    {
        public int NumberOrder { get; set; }
        public Client CustomerOrder { get; set; }
        public string Observation { get; set; }
        public ShoppingCart Cart { get; set; }

        public Order(int numberOrder, Client clientOrder, string observation, ShoppingCart products)
        {
            NumberOrder = numberOrder;
            CustomerOrder = clientOrder;
            Observation = observation;
            Cart = products;
        }

        public override string ToString()
        {
            StringBuilder s1 = new StringBuilder();
            s1.AppendLine($"Number order: {NumberOrder}");
            s1.AppendLine($"Client name: {CustomerOrder.Name}");
            s1.AppendLine($"Observation: {Observation}");
            s1.AppendLine();
            s1.AppendLine($"Order in information:");
            foreach(Product product in Cart.products)
            {                        
                s1.AppendLine($"Product's name: {product.Name}, Price of the product: R$: {product.Price}, Quantity: {product.Quantity}");               
            }
            s1.AppendLine($"Observation: {Observation}");
            return s1.ToString();

        }



    }
}
