using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using LinqAdvancedV;
public class Program
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>(); 

        students.Add(new Student { Id = 1, Name = "Ali"});
        students.Add(new Student { Id = 2, Name = "Ayşe" });
        students.Add(new Student { Id = 3, Name = "Ahmet" }); 

        List<Grade> grades = new List<Grade>();

        grades.Add(new Grade { StudentId = 1, Course = "Matematik", Score = 100 });

        grades.Add(new Grade { StudentId = 1, Course = "Türkçe", Score = 45 });

        grades.Add(new Grade { StudentId = 1, Course = "İngilizce", Score = 15 });

        grades.Add(new Grade { StudentId = 2, Course = "Matematik", Score = 25 });

        grades.Add(new Grade { StudentId = 3, Course = "Matematik", Score = 10 });

        grades.Add(new Grade { StudentId = 3, Course = "İngilizce", Score = 50 });

        //var studentGrades = students.Join(grades, 
        //                                  student => student.Id, 
        //                                  grade => grade.StudentId,
        //                                  (student,grade) => new
        //                                  {
        //                                      StudentName = student.Name,
        //                                      CourseName = grade.Course,
        //                                      Score = grade.Score,
        //                                  } 
        //                                  );

        var studentGrades = from student in students
                            join grade in grades on student.Id equals grade.StudentId
                            select new
                            {
                                StudentName = student.Name,
                                CourseName = grade.Course,
                                Score = grade.Score,
                            };

        foreach ( var student in studentGrades )
        {
            Console.WriteLine($"Öğrenci adı {student.StudentName} ders {student.CourseName} Not {student.Score}");

        }

        Console.WriteLine("___________________________");
        // groupjoın ile

        var studentWithGrades = students.GroupJoin(grades,
                                                   student => student.Id, 
                                                   grade => grade.StudentId,
                                                   (student, studentGrades) => new
                                                   {
                                                       StudentName = student.Name,
                                                       Grades = studentGrades
                                                   });
        foreach (var student in studentWithGrades)
        {  
            Console.WriteLine($"{student.StudentName}");
            Console.WriteLine("___Dersleri");
            foreach(var grade in student.Grades)
            {
                Console.WriteLine($"{grade.Course} -- {grade.Score}");
            }
        
        }

        Console.WriteLine("______________________");
        // sayılar ile gruplama

        //var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

        //var groupedAndSummed = numbers.GroupBy(num => num % 2 == 0 ? "Çift" : "Tek") 
        //                               .Select(group => new
        //                               {
        //                                   Key = group.Key,
        //                                   Sum = group.Sum(),
        //                               });
        //foreach( var group in groupedAndSummed )
        //{
        //    Console.WriteLine($"{group.Key} : toplam {group.Sum}");
        //}

        Console.WriteLine("__________________");

        // not ortalaması al
        var studentAverageGrades = students.Select(student => new
        {
            StudentName = student.Name,
            AverageGrade = grades.Where(s => s.StudentId == student.Id).Average(g => g.Score)
        });
        foreach (var student in studentAverageGrades)
        { Console.WriteLine($"{student.StudentName} ortalama: {student.AverageGrade}"); }

        Console.WriteLine("_______________________");

        var pagedStudents = students.OrderBy(student => student.Name) 
                                   .Skip(0) //indeks atla 
                                   .Take(1); // itibaren al

        foreach(var student in pagedStudents)
        {
            Console.WriteLine(student.Name);
        }


        // first hata fırlatır
        // fırstordefault o ve nul gosterır hata fırlatmaz  
        // last ifadede aynı sekılde


        // .Any herhangı birşey varmı yokmu arar 
        // students.Any(student => student.Name.StartsWith("A"));
        // All ise hepsinin koşulu saglması gerekır.

        //students.Count(student => student.Id > 1); // ıd bırden buyuk olanlaırn sayısını al

    }


}
