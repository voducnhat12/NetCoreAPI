using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models
{
    public class Employee : Person
    {
        public int EmpId { get; set; }
        public string Department { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}