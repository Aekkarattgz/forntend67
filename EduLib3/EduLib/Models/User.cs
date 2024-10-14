using System.ComponentModel.DataAnnotations;

namespace EduLib.Models
{
    public class User
    {
        [Key] // กำหนด Primary Key
        public int Id { get; set; } // Primary Key
        [Required]
        public string UserName { get; set; } // ชื่อผู้ใช้
        public string Email { get; set; } // อีเมล
        public string PasswordHash { get; set; } // รหัสผ่าน (เข้ารหัส)
        public string Role { get; set; } // บทบาท (เช่น Admin, Member)
    }
}
