using System.ComponentModel.DataAnnotations;

namespace ASP_Account.Model
{
    public class UserLoginDto
    {
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
    }
}
