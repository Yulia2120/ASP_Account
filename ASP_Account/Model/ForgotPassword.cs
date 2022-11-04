using System.ComponentModel.DataAnnotations;
#pragma warning disable CS8618
namespace ASP_Account.Model
{
    public class ForgotPassword
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

    }
}
