using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstMsSql.Data
{
    public class StudentEntity
    {
        public int Id { get; set; }

        [MaxLength(400)]
        public string FirstName { get; set; } = "";

        [MaxLength(400)]
        public string LastName { get; set; } = "";
        public int Age { get; set; }
    } 

}
