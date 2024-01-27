using LMS.BL;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal class Program
    {
        public static Predicate<Courses> courseid { get; private set; }

        static void Main(string[] args)
        {
            List<Teacher> Teacherlist = new List<Teacher>();
            List<Student> Studentlist = new List<Student>();
            List<Courses> Courselist = new List<Courses>();
            int state = 0;
            bool stets;
            while(true) 
            {
                state = SignUpAndIn();
                if (state == 1)
                {
                    state = Menu();
                    if (state == 1)
                    {
                        StudentSignUp(Studentlist);
                    }
                    else if (state == 2)
                    {
                        TeacherSignUp(Teacherlist);
                    }
                }
                state = SignUpAndIn();
                if(state == 2)
                { 
                    state = Menu();
                    if (state==1)
                     {
                    stets=StudentSignIn(Studentlist);
                    if(stets)
                    {
                        CourseRegister(Courselist, Studentlist);

                    }
                     }
                    else if(state==2)
                  {
                    stets = TeacherSignIn(Teacherlist);
                    if(stets)
                    {
                        CourseAdd(Courselist);
                    }
                 }
                }
            }
            Console.ReadKey();
        }
        static int Menu()
        {
            int num ;
            Console.WriteLine("1. Student ");
            Console.WriteLine("2. Teacher ");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        static int Menu2()
        {
            int num;
            Console.WriteLine("3. Student ");
            Console.WriteLine("4. Teacher ");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        static void TeacherSignUp(List<Teacher> list)
        {
            int id;
            string name;
            int password;
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Password");
            password = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter id: ");
            id = int.Parse(Console.ReadLine());
            Teacher p = new Teacher(name,password,id);
            list.Add(p);
        }
        static void StudentSignUp(List<Student> list)
        {
            int id;
            string name;
            int password;
            string course;
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Password");
            password = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter id: ");
            id = int.Parse(Console.ReadLine());
            Student p = new Student(name, password, id);
            list.Add(p);
        }
        static void CourseRegister(List<Courses> list,List<Student> Stulist)
        {
            int id;
            string name;
            int position = 0;
            int stuID =0;
            Console.WriteLine("Enter your Id: ");
            stuID = int.Parse(Console.ReadLine());
            // find position of the student logged in 
            for(int i = 0; i < list.Count; i++) 
            {
                Console.WriteLine("Id: "+list[i].courseid+"\t\tName: " + list[i].CourseName);
            }
            Console.WriteLine("Enter the name of the Course you want to Register in: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the id of the Course you want to Register in: ");
            id= int.Parse(Console.ReadLine());
            Courses C = new Courses(id,name);
            Stulist[stuID].AddCourse(C);
        }
        static void CourseAdd(List<Courses> list)
        {
            int id;
            string name;
            Console.WriteLine("Enter the name of the Course you want to add");
            name = Console.ReadLine();
            Console.WriteLine("Enter the id of the Course you want to add");
            id = int.Parse(Console.ReadLine());
            Courses C = new Courses(id, name);
            list.Add(C);
        }
        static int SignUpAndIn()
        {
            int num;
            Console.WriteLine("1. Sign Up");
            Console.WriteLine("2. Sign In");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        static bool StudentSignIn(List<Student> list)
        {
            int password;
            string name;
            Console.WriteLine("Enter your name: ");
            name= Console.ReadLine();
            Console.WriteLine("Enter your password");
            password = int.Parse(Console.ReadLine());
            for(int i = 0;i<list.Count;i++)
            {
                if (list[i].name == name && list[i].password==password)
                {
                    return true;
                }
            }
            return false;
        }
        static bool TeacherSignIn(List<Teacher> list)
        {
            int password;
            string name;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your password");
            password = int.Parse(Console.ReadLine());
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].name == name && list[i].Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        static void DisplayRegisteredData(List<Student> list)
        {
            Console.WriteLine();
        }
    }
}
