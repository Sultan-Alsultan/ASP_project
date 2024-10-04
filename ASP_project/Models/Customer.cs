using System.ComponentModel.DataAnnotations;

namespace ASP_project.Models
{
    public class Customer
    {
        [Key]
        public int Customer_Id { get; set; }
        [Required]
        public string? Customer_Name { get; set; }
        [Required]
        public string? Customer_Email { get; set; }
        [Required]
        public string? Customer_PhoneNumber { get; set; }
        [Required]
        public string? Customer_IdCardNumber { get; set; }
        public string? Customer_Note { get; set; }
           

    }
}
