using System.ComponentModel.DataAnnotations;

// Namespace này rất quan trọng
namespace DAL.Models
{
    public class TaiKhoan
    {
        [Key] // Đặt Username làm khóa chính
        [StringLength(100)]
        public string Username { get; set; }

        [Required] // Bắt buộc phải có
        [StringLength(100)]
        public string Password { get; set; }
    }
}