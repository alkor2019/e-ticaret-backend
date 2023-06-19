using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Domain.Entities;
using MediatR;

namespace E_Ticaret.Application.Features.Commands.ProductCommands.CreateCommand
{
    public class CreateProductCommandRequest:IRequest<CreateProductCommandResponse>
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public short UnitsInStock { get; set; }
    }
}