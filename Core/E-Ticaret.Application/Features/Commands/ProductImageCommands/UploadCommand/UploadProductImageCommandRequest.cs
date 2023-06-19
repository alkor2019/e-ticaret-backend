using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace E_Ticaret.Application.Features.Commands.ProductImageCommands.UploadCommand
{
    public class UploadProductImageCommandRequest:IRequest<UploadProductImageCommandResponse>
    {
        public int Id { get; set; }
        public IFormFileCollection? Files { get; set; }
    }
}