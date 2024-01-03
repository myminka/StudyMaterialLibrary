using Microsoft.AspNetCore.Mvc;

namespace StudyLibrary.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    public UserController()
    {

    }

    [HttpGet("{id}")]
    public void GetUser(int id)
    {
        var a = id;
    }
}
