using PD_App.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PD_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Admin> AdminList = new List<Admin>();
            List<Customer> CustomerList = new List<Customer>();
            List<Product> ProductList = new List<Product>();
            List<Employee> EmployeeList = new List<Employee>();
            int state ;
            bool astate;
            Banner();
            while (true) 
            {
                state = menu();
                if(state == 1)
                {
                    state = menu2();
                    if(state == 1)
                    {
                        Console.Clear();
                        SignInAdmin(AdminList);
                    }
                    else if(state == 2) 
                    {
                        Console.Clear();
                        SignInCustomer(CustomerList);
                    }
                }
                else if(state == 2)
                {
                    Console.Clear();
                    state = menu2();
                    if (state == 1)
                    {
                        Console.Clear();
                        astate = SignUpAdmin(AdminList);
                        if(astate)
                        {   
                            Console.Clear();
                            state = AdminMenu();
                            if (state == 1)
                            {
                                Console.Clear();
                                viewProduct(ProductList);
                            }
                            else if (state == 2)
                            {
                                Console.Clear();
                                AddProduct(ProductList);
                            }
                            else if (state == 3)
                            {
                                Console.Clear();
                                DisplayEmployee(EmployeeList);
                            }
                            else if (state == 4)
                            {
                                Console.Clear();
                                AddEmployee(EmployeeList);
                            }
                            else if (state == 5)
                            {
                                Console.Clear();
                                CurrentStock(ProductList);
                            }
                            else if(state == 6)
                            {
                                Console.Clear();
                                EmployeeSalary(EmployeeList);
                            }
                            else if( state == 7)
                            {
                                Console.Clear();
                                DisplaySalary(EmployeeList);
                            }
                                
                        }
                    }
                    else if (state == 2)
                    {
                        astate = SignUpCustomer(CustomerList);
                        if(astate)
                        {
                            state = CustomerMenu();
                            if(state==1)
                            {
                                Console.Clear();
                                viewProduct(ProductList);
                            }
                            else if(state==2)
                            {
                                Console.Clear();
                                Bill(ProductList);
                            }
                        }
                    }
                }
            }
        }
        static int menu()
        {
            int num = 0;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("1. Sign In");
            Console.WriteLine("2. Sign Up");
            Console.WriteLine("Enter a number ");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        static int menu2()
        {
            int num = 0;
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Customer");
            Console.WriteLine("Enter a number ");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        static void SignInAdmin(List<Admin> list)
        {
            string name;
            int password;
            int id;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            password = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your id: ");
            id = int.Parse(Console.ReadLine());
            Admin p = new Admin(name,password,id);
            list.Add(p);
            Console.ReadKey();

            //list.Add(p);
        }
        static bool SignUpAdmin(List<Admin> list)
        {
            string name;
            int password;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            password = int.Parse(Console.ReadLine());
            for(int i = 0; i < list.Count; i++) 
            {
                if(name == list[i].name && password == list[i].password)
                {
                    return true;
                }
            }
            return false;
        }
        static void SignInCustomer(List<Customer> list)
        {
            string name;
            int password;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            password = int.Parse(Console.ReadLine());
            Customer p = new Customer(name, password);
            list.Add(p);
            Console.ReadKey();

        }
        static bool SignUpCustomer(List<Customer> list)
        {
            string name;
            int password;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            password = int.Parse(Console.ReadLine());
            for (int i = 0; i < list.Count; i++)
            {
                if (name == list[i].name && password == list[i].password)
                {
                    return true;
                }
            }
            return false;
        }
        static void AddProduct(List<Product> list)
        {
            string name;
            int copies;
            int price;
            Console.WriteLine("Enter the name of book you want yo add in the shop");
            name = Console.ReadLine();
            Console.WriteLine("Enter the number of above product you want to add ");
            copies = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of the product per piece ");
            price = int.Parse(Console.ReadLine());
            Product b = new Product(name,copies,price);
            list.Add(b);
            Console.ReadKey();

        }
        static void Banner()
        {
            Console.ForegroundColor = ConsoleColor.Red; // Set console text color to red

            Console.WriteLine(" _________________________________________________________________________________________________");
            Thread.Sleep(300);
            Console.WriteLine("|                                                                                                 |");
            Thread.Sleep(300);
            Console.WriteLine("|                   _____ ______   ________  ___       ___  ___  __                               |");
            Thread.Sleep(300);
            Console.WriteLine("|                  |\\   _ \\  _   \\|\\   __  \\|\\  \\     |\\  \\|\\  \\|\\  \\                             |");
            Thread.Sleep(300);
            Console.WriteLine("|                   \\ \\  \\\\__\\ \\  \\ \\  \\|\\  \\ \\  \\    \\ \\  \\ \\  \\/  /|_                           |");
            Thread.Sleep(300);
            Console.WriteLine("|                    \\ \\  \\|__| \\  \\ \\   __  \\ \\  \\    \\ \\  \\ \\   ___  \\                          |");
            Thread.Sleep(300);
            Console.WriteLine("|                     \\ \\  \\    \\ \\  \\ \\  \\ \\  \\ \\  \\____\\ \\  \\ \\  \\ \\  \\                         |");
            Thread.Sleep(300);
            Console.WriteLine("|                      \\ \\__\\    \\ \\__\\ \\__\\ \\__\\ \\_______\\ \\__\\ \\__\\ \\__\\                        |");
            Thread.Sleep(300);
            Console.WriteLine("|                       \\|__|     \\|__|\\|__|\\|__|\\|_______|\\|__|\\|__| \\|__|                       |");
            Thread.Sleep(300);
            Console.WriteLine("|_________________________________________________________________________________________________|");
            Thread.Sleep(300);
            Console.WriteLine("|                                                                                                 |");
            Thread.Sleep(300);
            Console.WriteLine("|           ________  ________  ________  ________  _________  _______                            |");
            Thread.Sleep(300);
            Console.WriteLine("|          |\\   ____\\|\\   __  \\|\\   __  \\|\\   __  \\|\\___   ___\\   ____\\                           |");
            Thread.Sleep(300);
            Console.WriteLine("|          \\ \\  \\___|\\ \\  \\|\\  \\ \\  \\|\\  \\ \\  \\|\\  \\|___ \\  \\_\\ \\  \\__|__                         |");
            Thread.Sleep(300);
            Console.WriteLine("|           \\ \\_____  \\ \\   ____\\ \\  \\\\\\  \\ \\   _  _\\   \\ \\  \\ \\ \\_____  \\                        |");
            Thread.Sleep(300);
            Console.WriteLine("|            \\|____|\\  \\ \\  \\___|\\ \\  \\\\\\  \\ \\  \\\\  \\|   \\ \\  \\ \\|____|\\  \\                       |");
            Thread.Sleep(300);
            Console.WriteLine("|               ___\\_\\  \\ \\__\\    \\ \\_______\\ \\__\\ __\\    \\ \\__\\  ____\\_\\  \\                      |");
            Thread.Sleep(300);
            Console.WriteLine("|              |\\________\\|__|     \\|_______|\\|__|\\|__|    \\|__| |\\_________\\                     |");
            Thread.Sleep(300);
            Console.WriteLine("|              \\|_________|                                      \\|_________|                     |");
            Thread.Sleep(300);
            Console.WriteLine("|_________________________________________________________________________________________________|");

            Console.ResetColor(); // Reset console text color
        }
        static void CurrentStock(List<Product> list)
        {
            int sum = 0;
            Console.WriteLine("Name\t\tNumberavailable\t\tPrice");
            for(int i = 0; i < list.Count; i++) 
            {
                Console.WriteLine(list[i].name + "\t\t" + list[i].amount + "\t\t" + list[i].price);
                sum = sum + list[i].price;
            }
            Console.WriteLine("The total amount of money available in the form of Products: "+sum);
            Console.ReadKey();

        }
        static void Bill(List<Product> list)
        {
            int bill = 0;
            int count = 0;
            for(int i = 0;i<list.Count;i++)
            {
                Console.WriteLine(list[i].name + "\t\t" + list[i].amount + "\t\t" + list[i].price);
            }
            int arr;
            Console.WriteLine("Enter the number of products you want to buy ");
            arr = int.Parse(Console.ReadLine());
            string[] name = new string[arr];
            int[] amount = new int[arr];
            for(int i = 0;i<arr;i++)
            {
                Console.WriteLine("Enter the name of Product: ");
                name[i] = Console.ReadLine();
                Console.WriteLine("Enter the number of Products you want to buy: ");
                amount[i] = int.Parse(Console.ReadLine());
                count++;
                for(int j = 0;j <list.Count;j++)
                {
                    if (list[j].name == name[i]) 
                    {
                        bill = bill + amount[i] * list[i].price;
                    }
                }
            }
            Console.WriteLine("Your total Bill is: "+bill);
            Console.ReadKey();
        }
        static void AddEmployee(List<Employee> list)
        {
            int id;
            string name; 
            Console.WriteLine("Enter the name of Employee: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the id of the Employee: ");
            id = int.Parse(Console.ReadLine());
            Employee e = new Employee(name,id);
            list.Add(e);
            Console.ReadKey();

        }
        static void DisplayEmployee(List<Employee> list)
        {
            for(int i =0;i<list.Count;i++)
            {
                Console.WriteLine("Name: " + list[i].name+"\t ID: " + list[i].id);
            }
            Console.ReadKey();
        }
        static void EmployeeSalary(List<Employee> list)
        {
            string name;
            int holidays;
            int salary = 0;
            Console.WriteLine("Enter employee name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the number of holidays of the employee: ");
            holidays = int.Parse(Console.ReadLine());
            for(int j =0;j<list.Count;j++)
            {
                if (list[j].name == name) 
                {
                    if (holidays <= 15)
                    {
                        salary = list[j].salary - (holidays * 900);
                    }
                    else if (holidays <= 23)
                    {
                        salary = list[j].salary - (holidays * 1300);
                    }
                    else if (holidays > 23 && holidays < 25)
                    {
                        salary = 12000;
                    }
                    else
                    {
                        salary = 0;
                    }
                    list[j].salary = salary;
                }
            }
            Console.ReadKey();

        }
        static void DisplaySalary(List<Employee> list)
        {
            for(int j = 0;j<list.Count;j++) 
            {
                Console.WriteLine("Name: " + list[j].name+"\t"+"id: " + list[j].id+"\tsalary: " + list[j].salary);
            }
            Console.ReadKey();
        }
        static void viewProduct(List<Product> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].name + "\t" + list[i].amount + "\t" + list[i].price);
            }
            Console.ReadKey();
        }
        static int CustomerMenu()
        {
            int num;
            Console.WriteLine("1. To view Products");
            Console.WriteLine("2. To Buy Items");
            Console.WriteLine("3. To Exit");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        static int AdminMenu()
        {
            int num;
            Console.WriteLine("1. To View Product");
            Console.WriteLine("2. To Add Product");
            Console.WriteLine("3. To view Employee");
            Console.WriteLine("4. To Add Employee");
            Console.WriteLine("5. To View Stock ");
            Console.WriteLine("6. To Add Employee salary");
            Console.WriteLine("7. To View Employee salary");
            num = int.Parse(Console.ReadLine());
            return num;
        }
    }
}
