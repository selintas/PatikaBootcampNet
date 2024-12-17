using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models
{
    public class AuthorEditViewModel
    {
        public int Id { get; set; } // Benzersiz kimlik

        [Required(ErrorMessage = "'Yazar adı' girmek zorunludur.")]
        public string FirstName { get; set; } // Yazar adı 

        [Required(ErrorMessage = "'Yazar Soyadı' girmek zorunludur.")]
        public string LastName { get; set; } // Yazar soyadı 

        [Required(ErrorMessage = "'Tarih' girmek zorunludur.")]
        public DateTime DateOfBirth { get; set; } // Doğum tarihi 
       

        
    }
}
