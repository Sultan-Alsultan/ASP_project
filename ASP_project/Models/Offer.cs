using System.ComponentModel.DataAnnotations;

namespace ASP_project.Models
{
    public class Offer
    {
        [Key]
        public int Offer_Id { get; set; }
        [Required]
        public string? Offer_Name { get; set; }
        [Required]
        public string? Offer_Description { get; set; }
        [Required]
        public string? Offer_Status { get; set; }
        [Required]
        public string? Offer_Discount { get; set; }
        [Required]
        public string? Offer_Note { get; set; }
      
       


    }
}
