using System.ComponentModel.DataAnnotations;

namespace DemoBlazor.Pages.Demo3
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string Firstname { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Les deux champs doivent correspondre")]
        public string ConfirmPassword { get; set; }

    }
}
