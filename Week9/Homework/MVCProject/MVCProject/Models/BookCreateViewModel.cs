using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models
{
    public class BookCreateViewModel
    {
        [Required(ErrorMessage = "'Title' is required.")]
        public string Title { get; set; } // Book title

        [Required(ErrorMessage = "'Author' field is required.")]
        public int AuthorId { get; set; } // Author ID, references the Author model

        [Required(ErrorMessage = "'Genre' field is required.")]
        public string Genre { get; set; } // Book genre

        [Required(ErrorMessage = "'Publish Date' field is required.")]
        public DateTime PublishDate { get; set; } // Publish date

        [Required(ErrorMessage = "'ISBN Number' field is required.")]
        public string ISBN { get; set; } // ISBN number  

        [Required(ErrorMessage = "'Copies Available' field is required.")]
        public int CopiesAvailable { get; set; } // Available copies count
    }
}
