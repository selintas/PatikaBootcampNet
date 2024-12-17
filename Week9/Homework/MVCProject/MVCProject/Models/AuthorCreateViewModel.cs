using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models
{
    public class AuthorCreateViewModel
    {
        [Required(ErrorMessage = "'Yazar adı' girmek zorunludur.")]
        public string FirstName { get; set; } // Yazar adı 

        [Required(ErrorMessage = "'Yazar Soyadı' girmek zorunludur.")]
        public string LastName { get; set; } // Yazar soyadı 

        [Required(ErrorMessage = "'Tarih' girmek zorunludur.")]
        public DateTime DateOfBirth { get; set; } // Doğum tarihi 

        
    }
}
