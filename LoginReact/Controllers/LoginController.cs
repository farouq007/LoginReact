using LoginReact.Data;
using LoginReact.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly DataContext _context;

        public LoginController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("Login")]
        public async Task<ActionResult<string>> Login(User user)
        {
            _context.UsersLogin.Add(user);
            await _context.SaveChangesAsync();
            return Ok("Welcome");
        }
    }
}