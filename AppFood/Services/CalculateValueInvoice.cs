using AppFood.Entities;

namespace AppFood.Services
{
    class CalculateValueInvoice
    {
        static public double CalculateValue(ShoppingCart cart)
        {
            double totalValue = 0.0;

            foreach (Product product in cart.products)
            {
                totalValue += product.Price;
            }
            return totalValue;
        }
    }
}
