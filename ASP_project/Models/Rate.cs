using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_project.Models
{
    public class Rate
    {

        [Key]
        public int Rate_Id { get; set; }
        // select the booking id from the booking model
        [Required]
        [Display(Name ="Booking_Id")]
        public int Booking_Id { get; set; }
        [ForeignKey("Booking_Id")]
        [ValidateNever]
        public Booking? Booking { get; set; }
        // selecting the service name from the service model
        [Required]
        [Display(Name = "Service Name")]
      
        public int Service_Id { get; set; }
        [ForeignKey("Service_Id")]
        [ValidateNever]
        public Service? Service { get; set; }
        //=============================
        [Required]
        public int Rate_Value { get; set; }
        public  string? Rate_Date { get; set; }
        public string? Rate_Comment { get; set; }
    




    }
}
