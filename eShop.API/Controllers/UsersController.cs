using eShop.Core.DTO;
using eShop.Core.ServiceContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController(IUsersService _usersService) : ControllerBase
{
  //GET /api/Users/{userID}
  [HttpGet("{userID}")]
  public async Task<IActionResult> GetUserByUserID(Guid userID)
  {
    if (userID == Guid.Empty)
    {
      return BadRequest("Invalid User ID");
    }

   UserDTO? response = await _usersService.GetUserByUserID(userID);

    if (response == null)
    {
      return NotFound(response);
    }

    return Ok(response);
  }
}
