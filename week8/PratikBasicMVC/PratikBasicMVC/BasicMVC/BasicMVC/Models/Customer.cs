namespace BasicMVC.Models
{
    public class Customer
    {
        public int Id { get; set; } // Müşterinin benzersiz kimliği
        public string FirstName { get; set; } // Müşterinin adı
        public string LastName { get; set; } // Müşterinin soyadı
        public string Email { get; set; } // Müşterinin e-posta adresi
    }
}
