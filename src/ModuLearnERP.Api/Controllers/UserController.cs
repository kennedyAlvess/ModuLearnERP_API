using Microsoft.AspNetCore.Mvc;

namespace ModuLearnERP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] string user)
        {
            return Ok("User registered successfully");
        }
    }
}
