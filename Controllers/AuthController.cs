using FreshKart.Api.Data;
using FreshKart.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FreshKart.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly FreshKartContext _context;

        public AuthController(FreshKartContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(Login login)
        {
            var user = await _context.Login.FirstOrDefaultAsync(x =>
                x.Uname == login.Uname &&
                x.Pword == login.Pword);

            if (user == null)
            {
                return Unauthorized("Invalid username or password");
            }

            return Ok("Login successful");
        }
    }
}