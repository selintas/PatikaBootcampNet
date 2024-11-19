using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqJoinExample
{
    class Program
    {
        // Sınıf tanımı
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

        static void Main(string[] args)
        {
            // Öğrenciler listesi
            List<Student> students = new List<Student>
            {
                new Student { StudentId = 1, StudentName = "Ali", ClassId = 1 },
                new Student { StudentId = 2, StudentName = "Ayşe", ClassId = 2 },
                new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 1 },
                new Student { StudentId = 4, StudentName = "Fatma", ClassId = 3 }
            };

            // Sınıflar listesi
            List<Class> classes = new List<Class>
            {
                new Class { ClassId = 1, ClassName = "Matematik" },
                new Class { ClassId = 2, ClassName = "Türkçe" },
                new Class { ClassId = 3, ClassName = "Kimya" }
            };

            // Öğrenciler ve sınıflar arasında join işlemi
            var query = from student in students
                        join @class in classes
                        on student.ClassId equals @class.ClassId
                        select new
                        {
                            StudentName = student.StudentName,
                            ClassName = @class.ClassName
                        };

            // Sonuçları yazdır
            foreach (var item in query)
            {
                Console.WriteLine($"Öğrenci: {item.StudentName}, Sınıf: {item.ClassName}");
            }
        }
    }
}
