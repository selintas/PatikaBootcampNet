using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAdvancedV
{
    public class Student
    { 
        public int Id { get; set; }
        public string Name { get; set; }

    }

    public class Grade
    {
        public int StudentId { get; set; }
        public string Course { get; set; }
        public int Score { get; set; }
    }

}
