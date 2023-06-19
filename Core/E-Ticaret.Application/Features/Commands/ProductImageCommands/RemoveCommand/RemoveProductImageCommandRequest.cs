using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace E_Ticaret.Application.Features.Commands.ProductImageCommands.RemoveCommand
{
    public class RemoveProductImageCommandRequest:IRequest<RemoveProductImageCommandResponse>
    {
        public int Id { get; set; }
        public int ImageId { get; set; }
    }
}