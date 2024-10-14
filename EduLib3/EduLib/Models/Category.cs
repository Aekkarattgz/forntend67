using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EduLib.Models
{
    public class Category
    {
        [Key] // กำหนด Primary Key
        public int Id { get; set; } // Primary Key
        [Required]
        public string Name { get; set; } // ชื่อหมวดหมู่หนังสือ
    }
}
