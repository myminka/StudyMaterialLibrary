using Microsoft.AspNetCore.Mvc;
using StudyLibrary.Application.Abstractions;
using StudyLibrary.Application.ViewModels.User;

namespace StudyLibrary.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("{id}")]
    public IActionResult GetUserById(int id)
    {
        var user = _userService.GetUserByIdAsync(id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    [HttpGet]
    public IActionResult GetAllUsers()
    {
        var users = _userService.GetUsersAsync();
        if(users == null)
        {
            return NotFound();
        }
        return Ok(users);
    }

    [HttpPost]
    public IActionResult AddUser(AddUserViewModel newUser)
    {
        if(newUser == null)
        {
            return BadRequest("Invalid User");
        }
        var addedUser = _userService.AddUserAsync(newUser);
        var routeValues = new { id = addedUser.Id };
        return CreatedAtAction(nameof(GetUserById), routeValues, addedUser); 
    }
}
