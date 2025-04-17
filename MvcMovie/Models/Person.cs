using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models
{
    public class Person
    {
        [Key]
        public string Id { get; set; }
        [MinLength(3)]
        public string FullName { get; set; }
        public string? Address { get; set; }
    }
}