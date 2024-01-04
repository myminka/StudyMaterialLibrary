using Microsoft.AspNetCore.Mvc;
using StudyLibrary.Application.Abstractions;
using StudyLibrary.Entities;

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
        var user = _userService.GetUserById(id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    [HttpGet]
    public IActionResult GetAllUsers()
    {
        var users = _userService.GetAllUsers();
        if(users == null)
        {
            return NotFound();
        }
        return Ok(users);
    }

    [HttpPost]
    public IActionResult AddUser(User newUser)
    {
        if(newUser == null)
        {
            return BadRequest("Invalid User");
        }
        var addedUser = _userService.AddUser(newUser);
        var routeValues = new { id = addedUser.Id };
        return CreatedAtAction(nameof(GetUserById), routeValues, addedUser); 
    }
}
