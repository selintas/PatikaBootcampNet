using System.ComponentModel.DataAnnotations;

namespace MVCCrudOrnek.Models
{
    public class YeniOgrenciViewModel
    {
        [Display(Name ="Ogrenci Adı")]
        [Required(ErrorMessage ="Ad alanı zorunlu.")]
        [MaxLength(30, ErrorMessage = "ogrencı adı uzunluğu max 30 karakterden fazla olmaz.")]
        public string Ad { get; set; } = "";
        [Display(Name = "Tuttugu takım")]
        [Required(ErrorMessage = "'{0}' alanı zorunlu.")]
        [MaxLength(20, ErrorMessage ="Takım adı uzunluğu max 20 karakterden fazla olmaz.")]
        public string Takım { get; set; } = "";
        [Display(Name = "Doğum Yılı")]
        [Required(ErrorMessage = "'{0}' alan zorunlu.")]

        public int? DogumYili { get; set; } // ? koyunca null olabılır
    }
}
