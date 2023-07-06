using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace E_Ticaret.Application.Features.Commands.AuthCommands.RefreshTokenLoginCommands
{
    public class RefreshTokenLoginCommandRequest:IRequest<RefreshTokenLoginCommandResponse>
    {
        public string RefreshToken { get; set; }
        
    }
}