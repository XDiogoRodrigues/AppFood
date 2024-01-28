using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFood.Entities;
using AppFood.Views;


namespace AppFood
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("What would you like to accomplish: (1- Login | 2- Register)\nChoice: ");
                int choice = int.Parse(Console.ReadLine());
                ChoiceScreen.ChoicesScreen(choice);
            }
            catch (Exception)
            {
                Console.WriteLine("Option invalid or invalid data!");
            }
           
        }
    }
}
