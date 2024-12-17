using System.ComponentModel.DataAnnotations;

namespace MVCCrudOrnek.Models
{
    public class Ogrenci
    { 
        public int Id { get; set; }
        //[Display(Name = "Öğrencinin adı")] //ad kısmı değiştirdi.
        //[Required(ErrorMessage ="Ad alanı zorunlu.")] // yenı.cshtlmldekı hata mesajını verır sonrakı ıcın
        public string Ad { get; set; } = "";

        public int TakimId { get; set; }

        public int DogumYili { get; set; }
    }
}
