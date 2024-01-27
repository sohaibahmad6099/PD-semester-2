using Pd_task1_week3.BL;
using System;
using System.Collections.Generic;

namespace Pd_task1_week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int len = 3;
            int num = 0;
            string name;
            int age;
            string gender;
            int id = 0;
            List<Putabaz> list = new List<Putabaz>();
            Console.WriteLine("If you want to add data with 3 contructor type 1 ");
            Console.WriteLine("If you want to add data with 4 contructor type 2 ");
            num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                for (int i = 0; i < len; i++)
                {
                    Console.WriteLine("Enter your name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter your age: ");
                    age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Your gender: ");
                    gender = Console.ReadLine();
                    Putabaz p = new Putabaz(name, age, gender);
                    p.id = id;
                    list.Add(p);
                    id++;
                }
            }
            else if (num == 2)
            {
                for (int i = 0; i < len; i++)
                {
                    Console.WriteLine("Enter your name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter your age: ");
                    age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Your gender: ");
                    gender = Console.ReadLine();
                    Console.WriteLine("Enter your id: ");
                    id = int.Parse(Console.ReadLine());
                    Putabaz pd = new Putabaz(name, age, gender, id);
                    list.Add(pd);
                }
            }
            else
            {
                Putabaz pdf = new Putabaz();
                list.Add(pdf);
            }
            print(list);
            Console.ReadKey();


        }
        static void print(List<Putabaz> list)
        {
            Console.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].id);
                Console.WriteLine(list[i].name);
                Console.WriteLine(list[i].age);
                Console.WriteLine(list[i].gender);
            }
        }

    }
}
