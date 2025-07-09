using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEMOMVC.Models
{
    public class Person
    {
        public int? PersonID { get; set; }
        public string? FullName { get; set; }
        public string? Address { get; set; }
    }
}