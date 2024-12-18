using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomId { get; set; }
        [Required(ErrorMessage = "Please enter room number.")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Please enter room cover image.")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Please enter price.")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Please enter room title.")]
        [StringLength(100, ErrorMessage = "Maximum length is 100.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter bed number.")]
        public string BedCount { get; set; }
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Please enter description.")]
        public string Description { get; set; }
    }
}
