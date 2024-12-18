using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {
        public int RoomId { get; set; }
        [Required(ErrorMessage = "Please enter room number.")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Please enter price.")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Please enter room title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter bed number.")]
        public string BedCount { get; set; }
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
