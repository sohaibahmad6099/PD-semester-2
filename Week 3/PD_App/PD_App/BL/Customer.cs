using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_App.BL
{
    internal class Customer
    {
        public Customer(string name, int password) 
        {
            this.name = name;
            this.password = password;
        }
        public string name;
        public int password;
    }
}
