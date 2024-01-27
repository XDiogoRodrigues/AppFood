using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace AppFood.Views
{
    class ShowRefrigerator
    {
        public static void Show()
        {
            Dictionary<string, double> dict = new Dictionary<string, double>();
            string path = @"C:\Users\diogo\Desktop\MeusProjetos\AppFood\Products\Refrigerator\Refrigerator.txt";

            using(StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] vect = sr.ReadLine().Split(',');
                    string nameRefrigerator = vect[0];
                    double priceRefrigerator = double.Parse(vect[1], CultureInfo.InvariantCulture);
                    dict.Add(nameRefrigerator, priceRefrigerator);
                }
            }

            int number = 1;
            foreach(var refri in dict)
            {
                Console.WriteLine($"{number}-) Refrigerator name: {refri.Key}, Price: R$ {refri.Value.ToString("F2", CultureInfo.InvariantCulture)}");
                number++;
            }
        }
    }
}
