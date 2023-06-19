using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace E_Ticaret.Application.Features.Queries.CategoryQueries.GetAllQuery
{
    public class GetAllCategoryQueryRequest:IRequest<List<GetAllCategoryQueryResponse>>
    {
        
    }
}