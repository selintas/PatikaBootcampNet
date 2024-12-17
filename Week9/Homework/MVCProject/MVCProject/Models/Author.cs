namespace MVCProject.Models
{
    public class Author
    {
        public int Id { get; set; } // Benzersiz kimlik
        public string FirstName { get; set; } // Yazar adı
        public string LastName { get; set; } // Yazar soyadı
        public DateTime DateOfBirth { get; set; } // Doğum tarihi 
         
        public string FullName => $"{FirstName} {LastName}";
    }
}
