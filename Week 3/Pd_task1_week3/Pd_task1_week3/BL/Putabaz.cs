using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pd_task1_week3.BL
{
    internal class Putabaz
    {
        
        public Putabaz(string name,int age,string gender) 
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(gender);

        }
        public Putabaz(string name, int age, string gender,int id)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.id = id;
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(gender);
            Console.WriteLine(id);
        }
        public Putabaz()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(gender);
            Console.WriteLine(id);
        }

        public string name;
        public int age;
        public string gender;
        public int id;
    }
}
