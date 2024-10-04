using System.ComponentModel.DataAnnotations;

namespace ASP_project.Models
{
    public class Room
    {
        [Key]
        public int Room_ID { get; set; }
        public string? Room_Number { get; set; }
        [Required]
        public string? Room_Size { get; set; }
        public string?  Rent_Per_Day { get; set; }
        public string? Room_Status { get; set; }
        public string? Rent_Type { get; set; }
        public string? Room_Note { get; set; }

    }
}
