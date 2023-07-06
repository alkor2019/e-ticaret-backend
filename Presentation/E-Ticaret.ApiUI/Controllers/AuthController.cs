using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.Features.Commands.AuthCommands.FacebookLogin;
using E_Ticaret.Application.Features.Commands.AuthCommands.GoogleLogin;
using E_Ticaret.Application.Features.Commands.AuthCommands.LoginCommands;
using E_Ticaret.Application.Features.Commands.AuthCommands.RefreshTokenLoginCommands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret.ApiUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUserCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
            
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> RefreshTokenLogin(RefreshTokenLoginCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
            
        }
        [HttpPost("google-login")]
        public async Task<IActionResult> GoogleLogin(GoogleLoginCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
            
        }
        [HttpPost("facebook-login")]
        public async Task<IActionResult> FacebookLogin(FacebookLoginCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
            
        }
    
    }
}