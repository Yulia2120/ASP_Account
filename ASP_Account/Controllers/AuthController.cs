using ASP_Account.Data;
using ASP_Account.Model;
using ASP_Account.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Account.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserRegisterDto request)
        {
           ServiceResponse<int> response = await _authRepo.Register(
               new User { UserName = request.UserName }, request.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }




    }
}
