using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BL
{
    internal class Student
    {
        public Student(string name, int password, int id)
        {
            this.name = name;
            this.password = password;
            this.id = id;
        }
        public  void AddCourse(Courses C)
        {
            Courses.Add(C);
        }
        public string name;
        public int id;
        List<Courses> Courses = new List<Courses>();
        public int password;
    }
}
