using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceId { get; set; }

        [Required(ErrorMessage = "Enter service icon link.")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Enter service title.")]
        [StringLength(100, ErrorMessage = "Max length is 100 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Enter service description.")]
        [StringLength(500, ErrorMessage = "Max length is 500 characters.")]
        public string Description { get; set; }
    }
}
