using System.ComponentModel.DataAnnotations;

namespace ASP_Account.Model
#pragma warning disable CS8618
{
    public class User
    {
        public int Id { get; set; }
        [Required, MinLength(3), MaxLength(15)]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }



    }
}
