using ASP_Account.Model;
using ASP_Account.Services;

namespace ASP_Account.Data
{
    public interface IAuthRepository
    {

        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<string>> Login(string username, string password);
        Task<bool> UserExists(string username);
        Task<bool> ValidateUser(string name);

    }
}


   

    
