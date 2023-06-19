using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace E_Ticaret.Application.Features.Commands.ProductCommands.UpdateCommand
{
    public class UpdateProductCommandRequest:IRequest<UpdateProductCommandResponse>
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public short UnitsInStock { get; set; }
    }

}