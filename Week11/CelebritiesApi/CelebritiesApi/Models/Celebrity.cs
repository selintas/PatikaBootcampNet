namespace CelebritiesApi.Models
{
    public class Celebrity
    {
       
            public int Id { get; set; }         // Kişinin benzersiz kimliği
            public string Name { get; set; }    // Kişinin adı
            public string Profession { get; set; } // Kişinin mesleği (müzik sanatçısı, oyuncu, vb.)
    }
}
