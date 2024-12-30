namespace PratikCodeFirstRelation.Entities
{
    public class PostEntity
    {
        public int Id { get; set; }           // Gönderinin benzersiz kimliği
        public string Title { get; set; } = "";  // Gönderinin başlığı
        public string Content { get; set; } = ""; // Gönderinin içeriği
        public int UserId { get; set; }       // Gönderinin yazarı (kullanıcının kimliği)

        // Her gönderi yalnızca bir kullanıcıya aittir
        public UserEntity User { get; set; }
    }
}
