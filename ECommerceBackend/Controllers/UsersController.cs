using ECommerceBackend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("corspolicy")]
    public class UsersController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly UserContext _usuContext;
        public UsersController(IConfiguration configuration, UserContext usuContext)
        {
            _configuration = configuration;
            _usuContext = usuContext;
        }
        [HttpPost("CreateUser")]
        public IActionResult Create(User user)
        {
            if (_usuContext.Users.Where(u=>u.email == user.email).FirstOrDefault() != null)
            {
                return Ok("Already exixt!!");
            }
            user.memberSince = DateTime.Now;
            _usuContext.Users.Add(user);
            _usuContext.SaveChanges();
            return Ok("Success from create method");
        }
        // https://localhost:7114/

    }
}
