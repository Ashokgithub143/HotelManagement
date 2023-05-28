using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Authorizations
{
    public class RegisterModel
    {
        [Required(ErrorMessage="User name is required")]
        public string? Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage ="Email Address is required")]
        public string EmailAddress { get; set;}

        [Required(ErrorMessage ="Password is required")]
        public string? Password { get; set; }
    }
}
