using System;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
	[Route("api/users")]
	public class UserController : ControllerBase
	{

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // api/users/1
        [HttpGet("{id}")]
		public IActionResult getById(int id)
		{
			return Ok();
		}
		// api/users
		[HttpPost]
        public IActionResult Post([FromBody] NewUserInputModel inputModel)
		{

			_userService.RegisterUser(inputModel);

			return Ok();
		}

		// api/users/1/login
		[HttpPost("{id}/login")]
		public IActionResult Login(int id, [FromBody] LoginInputModel login)
		{
			return NoContent();
		}



    }
}

