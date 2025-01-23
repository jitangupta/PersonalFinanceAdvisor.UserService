using Microsoft.AspNetCore.Mvc;

namespace PersonalFinanceAdvisor.UserService.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("User service is up & running.");
        }
    }
}
