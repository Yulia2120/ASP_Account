using System.ComponentModel.DataAnnotations;

namespace ASP_Account.Model
{
    public class User
    {
        public int Id { get; set; }
        [Required, MinLength(3), MaxLength(15)]
        public string UserName { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } 
        public byte[] PasswordSalt { get; set; }




    }
}
