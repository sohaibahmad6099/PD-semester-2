using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LMS.BL
{
    internal class Teacher
    {
        public Teacher(string name,int password,int id)
        {
            this.name = name;
            this.Password = password;
            this.id = id;
        }
        public string name;
        public int id;
        public string CourseName;
        public int courseid;
        public int Password;
    }
}
