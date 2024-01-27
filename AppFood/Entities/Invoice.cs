using System.Linq;
using System.Text;
using System.Globalization;

namespace AppFood.Entities
{
    class Invoice
    {
        public int NumberInvoice { get; set; }
        private double _totalOrderValue { get; set; }
        public ShoppingCart Cart { get; set; }

        public Invoice(int numberInvoice, ShoppingCart cart)
        {
            NumberInvoice = numberInvoice;
            Cart = cart;
        }
        public override string ToString()
        {
            StringBuilder s1 = new StringBuilder();
            s1.AppendLine($"Invoice number: {NumberInvoice}");
            foreach(Product product in Cart.products)
            {
                s1.AppendLine($"Name's product: {product.Name}, Price of product: {product.Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {product.Quantity}");
            }
            s1.AppendLine($"Total order value: {_totalOrderValue.ToString("F2", CultureInfo.InvariantCulture)}");
            return s1.ToString();

        }


    }
}
