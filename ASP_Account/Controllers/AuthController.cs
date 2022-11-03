using ASP_Account.Data;
using ASP_Account.Model;
using ASP_Account.Services;
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
        [HttpGet]
        public IAsyncEnumerable<string> GetAll()
        {
            return _authRepo.GetUsers();
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromForm]UserRegisterDto request)
        {
              ServiceResponse<int> response = await _authRepo.Register(
               new User { UserName = request.UserName }, request.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromForm]UserLoginDto request)
        {
            ServiceResponse<string> response = await _authRepo.Login(
                request.UserName, request.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }



    }
}
