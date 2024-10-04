using System.ComponentModel.DataAnnotations;

namespace ASP_project.Models
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }
        [Required]
        public string? User_Frist_Name { get; set; }
        public string? User_Last_Name { get; set; }
        [Required]
        [EmailAddress]
        public string? User_Email { get; set; }
        public string? User_Password { get; set; }
        public string? User_PhoneNumber { get; set; }
        public bool User_Role { get; set; }
    }
}
