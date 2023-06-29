using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace E_Ticaret.Application.Features.Queries.ProductImageQueries.GetByProductIdQuery
{
    public class GetByProductIdProductImageQueryRequest:IRequest<GetByProductIdProductImageQueryResponse>
    {
        public int Id { get; set; }
    }
}