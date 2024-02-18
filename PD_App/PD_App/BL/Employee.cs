using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_App.BL
{
    internal class Employee
    {
        public Employee(string name,int id) 
        {
            this.name = name;
            this.id = id;
            salary = 50000;
        }
       public string name;
        public int salary;
        public int age;
        public int id;
    }
}
