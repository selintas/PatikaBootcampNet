namespace CodeFirstAraTablo.Data.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        // Öğrencinin aldığı derslerin listesi
        public List<StudentCourse>? StudentCourses { get; set; } 
    }
}
