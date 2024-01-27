using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFood.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Client(string name, string phone, string address)
        {
            Name = name;
            Phone = phone;
            Address = address;
        }
    }
}
