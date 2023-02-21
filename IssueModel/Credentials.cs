using System.ComponentModel.DataAnnotations;

namespace IssueModel
{
    public class Credentials
    {
        [Required(ErrorMessage = "UserName is required")]
        [StringLength(25)]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        [StringLength(12)]
        public string Password { get; set; } = string.Empty;
    }
}
