using System.ComponentModel.DataAnnotations;

namespace ASP_Account.Model
{
    public class UserRegisterDto
    {
        [Required, MinLength(3), MaxLength(15)]
        public string UserName { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        [StringLength(100, ErrorMessage = "Пароль должен содержать как минимум 6 символов", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
        
    }
}
//DTO — это объект, определяющий способ отправки данных по сети.