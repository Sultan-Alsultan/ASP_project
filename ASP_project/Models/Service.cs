using System.ComponentModel.DataAnnotations;

namespace ASP_project.Models
{
    public class Service
    {
        [Key]
        public int Service_Id { get; set; }
        [Required]
        public string? Service_Name { get; set; }
        [Required]
        public string? Service_Description { get; set; }
        [Required]
        public string? Service_Status { get; set; }
        [Required]
        public string? Service_Type { get; set; }
        [Required]
        public string? Service_Date { get; set; }
        public string? Service_Price { get; set; }


    }
}
