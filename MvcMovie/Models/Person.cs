using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        [Required]
        public string PersonId { get; set; } = default!;
        public string? FullName { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
    }

}
