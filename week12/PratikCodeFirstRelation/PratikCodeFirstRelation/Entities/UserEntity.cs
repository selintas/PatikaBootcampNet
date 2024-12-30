namespace PratikCodeFirstRelation.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }            // Kullanıcının benzersiz kimliği
        public string Username { get; set; } = ""; // Kullanıcının kullanıcı adı
        public string Email { get; set; } = "";   // Kullanıcının e-posta adresi

        // Bir kullanıcının birden fazla gönderisi olabilir
        public List<PostEntity> Posts { get; set; }
    }
}
