using System.Text;
using System.Globalization;

namespace AppFood.Entities
{
    class Snack: Product
    {
        public string[] Ingredients;

        public Snack(string name, double price, int quantity, string[] ingredients) : base(name, price, quantity)
        {
            Ingredients = ingredients;
        }

        public override string ToString()
        {
            StringBuilder s1 = new StringBuilder();
            s1.AppendLine($"Name: {Name}, Price: R$ {Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {Quantity}");
            s1.Append($"Ingredients: ");
            foreach (string str in Ingredients)
            {
                s1.Append($"{str}, ");
            }
            return s1.ToString();
        }
    }
}
