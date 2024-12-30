namespace PratikCodeFirstBasic.Data.Entities
{
    public class Game
    {
        public int Id { get; set; } // Birincil Anahtar
        public string Name { get; set; } // Oyunun Adı
        public string Platform { get; set; } // Oyunun Platformu
        public decimal Rating { get; set; } // Oyunun Puanı (0-10)
    }
}
