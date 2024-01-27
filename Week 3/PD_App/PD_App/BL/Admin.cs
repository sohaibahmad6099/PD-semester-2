using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_App.BL
{
    internal class Admin
    {
        public Admin(string name,int password,int id) 
        {
            this.name = name;
            this.password = password;
            this.id = id;
        }
        public string name;
        public int password;
        public int id;  
    }
}
