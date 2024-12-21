using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Name required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname required.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Username required.")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Mail required.")]
        public string Mail { get; set; }
        
        [Required(ErrorMessage = "Password required.")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Password confirm required.")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
