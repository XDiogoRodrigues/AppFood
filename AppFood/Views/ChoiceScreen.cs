using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFood.Views
{
    class ChoiceScreen
    {
        public static void ChoicesScreen(int choice)
        {
            if(choice == 1)
            {
                Console.WriteLine("-------------- Login ------------------");

            }
            else if(choice == 2)
            {
                Console.WriteLine("-------------- Register ---------------");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
        }
    }
}
