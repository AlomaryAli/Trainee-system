using System;
using System.ComponentModel.DataAnnotations;

namespace UserManagement02.Models
{
    public class AppUser
    {
        [Key]
        public int UserID { get; set; }

        [Required, MaxLength(100)]
        public string? FullName { get; set; }

        [Required, EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public string? Role { get; set; } // HR, Supervisor, SectionHead, Intern, Admin

        [Required]
        public string? PhoneNumber { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}