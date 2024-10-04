using System.ComponentModel.DataAnnotations;

namespace ASP_project.Models
{
    public class Payment
    {
        [Key]
        public int Payment_Id { get; set; }
        [Required]
        public string? Payment_Amount { get; set; }
        [Required]
        public string? Payment_Currency { get; set; }
        [Required]
        public string? Payment_Date { get; set; }
        [Required]
        public string? Payment_Method { get; set; }
        [Required]
        public string? Payment_Status { get; set; }
        public string? Payment_Note { get; set; }
    }
}
