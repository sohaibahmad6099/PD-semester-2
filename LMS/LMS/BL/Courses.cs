using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BL
{
    internal class Courses
    {
        public Courses(int id, string name)
        {
            courseid = id;
            CourseName = name;
        }
        public int courseid;
        public string CourseName;
    }
}
