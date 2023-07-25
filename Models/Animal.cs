using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("Animal")]
    public class Animal
    {
        [Key]
        public string MaBan {get; set;}
        public string KhachHang {get; set;}
        public DateTime NgayBan {get; set;}

    }
}