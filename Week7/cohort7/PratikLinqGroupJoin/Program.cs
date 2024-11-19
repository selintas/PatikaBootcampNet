using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PratikLinqGroupJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sınıf verileri
            List<Class> classes = new List<Class>
            {
                new Class { ClassId = 1, ClassName = "Matematik" },
                new Class { ClassId = 2, ClassName = "Türkçe" },
                new Class { ClassId = 3, ClassName = "Kimya" }
            };

            // Öğrenci verileri
            List<Student> students = new List<Student>
            {
                new Student { StudentId = 1, StudentName = "Ali", ClassId = 1 },
                new Student { StudentId = 2, StudentName = "Ayşe", ClassId = 2 },
                new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 3 },
                new Student { StudentId = 4, StudentName = "Fatma", ClassId = 4 },
                new Student { StudentId = 5, StudentName = "Ahmet", ClassId = 5 }
            };

            // LINQ Group Join
            var query = from cls in classes
                        join stu in students
                        on cls.ClassId equals stu.ClassId into studentGroup
                        select new
                        {
                            ClassName = cls.ClassName,  // Sınıf adı
                            Students = studentGroup    // Sınıfa ait öğrenciler grubu
                        };

            // Sonuçları ekrana yazdırma
            foreach (var item in query)
            {
                Console.WriteLine($"Sınıf: {item.ClassName}");
                if (item.Students.Any())
                {
                    foreach (var student in item.Students)
                    {
                        Console.WriteLine($"  Öğrenci: {student.StudentName}");
                    }
                }
                else
                {
                    Console.WriteLine("  Bu sınıfta öğrenci yok.");
                }
            }

            // Programın sonlanmasını bekletmek için
            Console.ReadLine();
        }
    }
}