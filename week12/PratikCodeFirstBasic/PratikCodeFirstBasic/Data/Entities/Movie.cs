namespace PratikCodeFirstBasic.Data.Entities
{
    public class Movie
    {
        public int Id { get; set; } // Birincil Anahtar
        public string Title { get; set; } // Filmin Başlığı
        public string Genre { get; set; } // Filmin Türü
        public int ReleaseYear { get; set; } // Filmin Çıkış Yılı
    }
}
