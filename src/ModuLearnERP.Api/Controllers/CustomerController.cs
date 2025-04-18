using Microsoft.AspNetCore.Mvc;

namespace ModuLearnERP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public IActionResult Register([FromBody] string customer)
        {
            return Ok("Customer registered successfully");
        }
    }
}
