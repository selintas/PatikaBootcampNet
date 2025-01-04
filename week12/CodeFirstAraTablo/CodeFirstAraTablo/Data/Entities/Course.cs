namespace CodeFirstAraTablo.Data.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";

        // Dersin alındığı öğrencilerin listesi
        public List<StudentCourse>? StudentCourses { get; set; }
    }
}
