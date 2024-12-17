namespace MVCProject.Models
{
    public class AuthorViewModel
    {
        public int Id { get; set; } // Benzersiz kimlik
        public string FullName { get; set; } // Yazar adı

        public DateTime DateOfBirth { get; set; } // Doğum tarihi 
    }
}
