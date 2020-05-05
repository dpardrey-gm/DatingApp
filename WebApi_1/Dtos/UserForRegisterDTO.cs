using System.ComponentModel.DataAnnotations;

namespace WebApi_1.Dtos
{
    public class UserForRegisterDTO
    {
        [Required]
        public string Username { get; set; }    

        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }    
    }
}