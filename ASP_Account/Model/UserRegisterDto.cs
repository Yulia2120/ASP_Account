namespace ASP_Account.Model
{
    public class UserRegisterDto
    {
        //internal readonly bool IsValid;

        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        
    }
}
//DTO — это объект, определяющий способ отправки данных по сети.