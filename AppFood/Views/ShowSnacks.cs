using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace AppFood.Views
{
    class ShowSnacks
    {
        public static void Show()
        {
            string path = @"C:\Users\diogo\Desktop\MeusProjetos\AppFood\Products\Snacks\snacks.txt";
            Dictionary<string, double> dict = new Dictionary<string, double>();

            using (StreamReader s1 = File.OpenText(path)) {
                while (!s1.EndOfStream)
                {
                    string[] vect = s1.ReadLine().Split('_');
                    string nameSnack = vect[0];
                    double priceSnack = double.Parse(vect[1], CultureInfo.InvariantCulture);
                    dict.Add(nameSnack, priceSnack);

                }
            }
            int number = 1;
            foreach(var snak in dict)
            {
                Console.WriteLine($"{number}-) Snack name: {snak.Key}, Price: R$ {snak.Value.ToString("F2", CultureInfo.InvariantCulture)}");
                number++;
            }
        }
    }
}
