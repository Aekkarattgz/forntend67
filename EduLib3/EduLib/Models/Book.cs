using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EduLib.Models
{
    public class Book{
        [Key] // กำหนด Primary Key
        public int Id { get; set; } // Primary Key
        [Required]
        public string Title { get; set; } // ชื่อหนังสือ
        public string Author { get; set; } // ผู้แต่ง
        public string ISBN { get; set; } // หมายเลข ISBN
        
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; } // FK สำหรับ Category
        public Category Category { get; set; } // นำไปใช้ในการเชื่อมต่อกับ Category
        public string ImageUrl { get; set; } // URL ของรูปภาพหนังสือ

    }

}
