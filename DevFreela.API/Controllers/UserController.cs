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
        [ProducesResponseType<UserModel>(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult getById(int id)
		{
			var user = _userService.GetUserById(id);

			if(user == null)
			{
				return NoContent();
			}

			return Ok(user);
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

