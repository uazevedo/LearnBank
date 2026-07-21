using LearnBank.Application.Features.Users.CreateUser;
using Microsoft.AspNetCore.Mvc;

namespace LearnBank.Api.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController(CreateUserHandler createUserHandler) : ControllerBase
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
}

