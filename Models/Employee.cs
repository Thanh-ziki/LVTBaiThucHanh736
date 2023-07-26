using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public string Id {get; set;}
        public string Name {get; set;}
        public string Address {get; set;}
    }
}