using E_Ticaret.Application.Abstractions.Results;
using E_Ticaret.Domain.Entities;

namespace E_Ticaret.Application.Features.Queries.CategoryQueries.GetAllQuery
{
    public class GetAllCategoryQueryResponse : DataResult<List<Category>>
    {
        public GetAllCategoryQueryResponse(List<Category> data, string message, bool success) : base(data, message, success)
        {
        }
    }
}