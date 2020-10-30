using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SS.Services.Interface.IUserServices;
using SS.Services.ViewModels.User;

namespace SS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserServices _userServices;
        public UsersController(IUserServices userServices)
        {
            _userServices = userServices;
        }
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromForm] LoginViewModel model)
        {
            var resultToken = await _userServices.Authencation(model);
            return !string.IsNullOrEmpty(resultToken) ?
                (IActionResult)Ok(new { token = resultToken }) :
                BadRequest("UserName or Password is incorrect");
        }
        [AllowAnonymous]
        [HttpPost("resgister")]
        public async Task<IActionResult> Register([FromForm] RegisterViewModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _userServices.Register(model);
            return !(result == false) ? (IActionResult)Ok() : BadRequest("");
        }
    }
}
