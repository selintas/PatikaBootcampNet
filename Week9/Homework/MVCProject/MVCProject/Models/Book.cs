namespace MVCProject.Models
{
    public class Book
    {
        public int Id { get; set; } // Benzersiz kimlik
        public string Title { get; set; } // Kitap başlığı
        public int AuthorId { get; set; } // Yazar kimliği, Author modeline referans
        public string Genre { get; set; } // Kitap türü
        public DateTime PublishDate { get; set; } // Yayın tarihi
        public string ISBN { get; set; } // ISBN numarası
        public int CopiesAvailable { get; set; } // Mevcut kopya sayısı
    }
}
