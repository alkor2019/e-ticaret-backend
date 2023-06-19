using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace E_Ticaret.Application.Features.Commands.ProductCommands.RemoveCommand
{
    public class RemoveProductCommandRequest:IRequest<RemoveProductCommandResponse>
    {
        public int Id { get; set; }
    }
}