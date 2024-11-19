using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikLinqGroupJoin
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }
    }

    public class Class
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
    }
}
