using FortBase.Model;
using FortBase.Service;
using Microsoft.AspNetCore.Mvc;

namespace FortBase.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost("SaveUser")]
        public IActionResult SaveUser(UserModel userModel)
        {
            var userService = new UserService();
            var result = userService.SaveUser(userModel);
            return Ok(result);
        }
    }
}