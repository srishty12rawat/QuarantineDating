using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Controllers.Data.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username {get; set;}

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Password length should be between 3 and 9")]
        public string password {get; set;}
    }
}