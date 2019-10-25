using FortBase.Data;
using FortBase.Model;
using FortBase.Service;
using Microsoft.AspNetCore.Mvc;

namespace FortBase.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly FortBaseDbContext dbContext;

        public UserController(FortBaseDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost("SaveUser")]
        public IActionResult SaveUser(UserModel userModel)
        {
            var userService = new UserService(dbContext);
            var result = userService.SaveUser(userModel);
            return Ok(result);
        }
    }
}