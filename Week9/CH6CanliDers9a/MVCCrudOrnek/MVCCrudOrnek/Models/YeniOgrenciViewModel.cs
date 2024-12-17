using System.ComponentModel.DataAnnotations;

namespace MVCCrudOrnek.Models
{
    public class YeniOgrenciViewModel
    {
        [Display(Name = "Eklenecek Öğrencinin Adı")]
        [Required(ErrorMessage = "'Ad' alanı zorunludur.")]
        [MaxLength(20, ErrorMessage = "Öğrencinin adı 30 karakterden uzun olamaz.")]
        public string Ad { get; set; } = "";

        [Display(Name = "Tuttuğu Takım")]
        [Required(ErrorMessage = "'{0}' alanı zorunludur.")]
        public int? TakimId { get; set; }

        [Display(Name = "Doğum Yılı")]
        [Required(ErrorMessage = "'{0}' alan zorunludur.")]
        public int? DogumYili { get; set; }
    }
}