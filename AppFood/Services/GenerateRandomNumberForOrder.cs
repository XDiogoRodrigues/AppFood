using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFood.Services
{
     class GenerateRandomNumberForOrder
    {
        static public int GenerateNumber()
        {
            Random r1 = new Random();
            int number = r1.Next(1, 500);
            return number;
        }
    }
}
