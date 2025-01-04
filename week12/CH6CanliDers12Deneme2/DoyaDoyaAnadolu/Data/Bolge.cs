using System.ComponentModel.DataAnnotations;

namespace DoyaDoyaAnadolu.Data
{
    public class Bolge
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string BolgeAd { get; set; } = "";


        public List<Sehir> Sehirler { get; set; } = new();
    }
}
