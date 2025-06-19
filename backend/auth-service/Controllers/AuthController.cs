using Microsoft.AspNetCore.Mvc;
using auth_service.Models;
using auth_service.Services;

namespace auth_service.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var token = _authService.Authenticate(request.Username, request.Password);
            return token != null ? Ok(new { Token = token }) : Unauthorized();
        }
    }
}
