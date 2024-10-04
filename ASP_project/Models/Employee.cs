using System.ComponentModel.DataAnnotations;

namespace ASP_project.Models
{
    public class Employee
    {
        [Key]
        public int Employee_Id { get; set; }
        [Required]
        public string? Employee_Name { get; set; }
        [Required]  
        public string? Employee_PhoneNumber { get;set; }
        [Required]
        public string? Employee_Email { get; set; }
        [Required]
        public string? Employee_Password { get; set; }
        [Required]
        public string? Employee_Role { get; set; }
        [Required]
        // passport or the id 
        public string? Employee_IdCardNumber { get; set; }
        public string? Employee_Note { get; set; }
    }
}
