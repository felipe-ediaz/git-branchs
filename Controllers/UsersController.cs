
using git_branchs.Entities;
using Microsoft.AspNetCore.Mvc;

namespace git_branchs.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class UsersController : ControllerBase {
    private static List<User> Users { get; set; } = new List<User>();

    [HttpGet]
    public async Task<ActionResult<List<User>>> GetAsync(){
        
        var users = await Task.FromResult(Users);
        return Ok(users);
    }

    [HttpPost]
    public async Task<ActionResult<User>> PostAsync(
        [FromBody] User user
    ){
        Users.Add(user);

        var createdUser = await Task.FromResult(user);

        return Ok(user);
    }

}