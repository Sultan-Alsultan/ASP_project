using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_project.Models
{
    public class Booking
    {
        [Key]
        public int Booking_Id { get; set; }
        // getting the number  of the room from the room model
        [Required]
        [Display(Name ="room number")]
        public int Room_Id { get; set; }
        [ForeignKey("Room_Id")]
        [ValidateNever]
        public Room? Room { get; set; }
        //  getting the name of the employee from the employee model
        [Required]
        [Display(Name = "Employee name")]
        public int Employee_Id { get; set; }
        [ForeignKey("Employee_Id")]
        [ValidateNever]
        public Employee? Employee { get; set; }
        // entering the customer information from the booking model
        [Required]
        [Display(Name = "Customer name")]
        public int Customer_Id { get; set; }
        [ForeignKey("Customer_Id")]
        [ValidateNever]
        public Customer? Customer { get; set; }
        //==========================================
        [Required]
        public string? Booking_Date { get; set; }
        [Required]
        public string? CheckIn_Date { get; set; }
        [Required]
        public string? CheckOut_Date { get; set; }
        // entering the informatin of the payment from the booking model
        [Required]
        [Display(Name = "Amount")]
        public int Payment_Id { get; set; }
        [ForeignKey("Payment_Id")]
        [ValidateNever]
        public Payment? Payment { get; set; }
        // getting the name of the offer and the discount precent from the offer model
        [Required]
        [Display(Name = "Offer name")]
        public int Offer_Id { get; set; }
        [ForeignKey("Offer_Id")]
        [ValidateNever]
        public Offer? Offer { get; set; }
        //====================================
       
        public  string? Booking_Note { get; set; }


    }
}
