using System.ComponentModel.DataAnnotations;

namespace AccuGazer.API.Dtos
{
    public class UserRegisterDto
    {
        [Required]
        public string FirstName { get; set; }
       
        [Required]
        public string LastName { get; set; }
       
        [Required]
        public string Gender { get; set; }
       
        [Required]
        public long DateOfBirth { get; set; }
       
        [Required]
        [EmailAddress]
        public string Email { get; set; }
       
        [Required]
        [StringLength(16, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 16 characters long")]
        public string Password { get; set; }
    }
}