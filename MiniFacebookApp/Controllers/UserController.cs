using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniFacebookApp.Services.Interfaces;

namespace MiniFacebookApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UserController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _usersService.GetAllUsersAsync();

            return Ok(users);
        }
    }
}
