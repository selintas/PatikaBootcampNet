namespace MVCProject.Models
{
    public class BookViewModel
    {
        public int Id { get; set; } // Kitap ID
        public string Title { get; set; } // Kitap başlığı
        public string AuthorFullName { get; set; } // Yazarın tam adı (FirstName + LastName)
        public string Genre { get; set; } // Kitap türü
        public DateTime PublishDate { get; set; } // Yayın tarihi
        public string ISBN { get; set; } // ISBN numarası
        public int CopiesAvailable { get; set; } // Mevcut kopya sayısı
    }
}
