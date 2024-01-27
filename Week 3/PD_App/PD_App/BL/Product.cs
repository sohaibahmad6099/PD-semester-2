using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_App.BL
{
    internal class Product
    {
        public Product(string name,int price,int amount)
        {
            this.name = name;
            this.price = price;
            this.amount = amount;
        }
       public string name;
       public int price;
       public int amount;
    }
}
