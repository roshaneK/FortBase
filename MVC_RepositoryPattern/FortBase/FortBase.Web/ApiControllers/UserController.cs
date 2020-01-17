using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FortBase.Service.Contracts.UserContracts;
using FortBase.Service.Models.UserViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FortBase.Web.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet("GetUsers")]
        public IActionResult GetUsers()
        {
            var result = userService.GetUsers();
            return Ok(result);
        }

        [HttpPost("SaveUser")]
        public IActionResult SaveUser(UserVM userVM)
        {
            var result = userService.SaveUser(userVM);
            return Ok(result);
        }
    }
}