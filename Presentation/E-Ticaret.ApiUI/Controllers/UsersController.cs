

using E_Ticaret.Application.Features.Commands.AuthCommands;
using E_Ticaret.Application.Features.Commands.AuthCommands.GoogleLogin;
using E_Ticaret.Application.Features.Commands.UsersCommands.RegisterCommand;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret.ApiUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController:ControllerBase
    {
         private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
            
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginUserCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
            
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GoogleLogin(GoogleLoginCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
            
        }
    }
}