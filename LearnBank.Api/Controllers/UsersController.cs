using LearnBank.Application.Features.Users.CreateUser;
using LearnBank.Application.Features.Users.ListUsers;
using Microsoft.AspNetCore.Mvc;

namespace LearnBank.Api.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController(
    CreateUserHandler createUserHandler,
    ListUsersHandler listUsersHandler) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateUserRequest request)
    {
        var response = await createUserHandler.HandleAsync(new CreateUserCommand(
            request.FullName,
            request.Email,
            request.TaxIdentificationNumber,
            request.Gender));

        return Created($"/api/users/{response.Id}",response);
    }

    [HttpGet]
    public async Task<IActionResult> ListAsync()
    {
        var response = await listUsersHandler.HandleAsync(new ListUsersQuery());

        return Ok(response);
    }
}

