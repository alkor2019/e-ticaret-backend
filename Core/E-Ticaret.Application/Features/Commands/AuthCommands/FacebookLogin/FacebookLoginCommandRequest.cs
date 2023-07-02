using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace E_Ticaret.Application.Features.Commands.AuthCommands.FacebookLogin
{
    public class FacebookLoginCommandRequest:IRequest<FacebookLoginCommandResponse>
    {
        public string AuthToken { get; set; }
        
        
    }
}